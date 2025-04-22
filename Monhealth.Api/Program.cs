using Monhealth.Api.Extensions;
using Monhealth.Api.GlobalException;
using Monhealth.Api.Hubs;
using Monhealth.Api.Utils;
using Monhealth.Application;
using Monhealth.Application.Models.Phone;
using Monhealth.Application.Services;
using Monhealth.Identity;
using Monhealth.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Cấu hình SignalR
builder.Services.AddSignalR(); // Thêm SignalR vào dịch vụ

var twilioSettings = builder.Configuration.GetSection("Twilio").Get<TwilioSettings>();
builder.Services.AddSingleton(twilioSettings);

// Cấu hình Serilog
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

// Thêm các dịch vụ khác vào container
builder.Services.AddApplicationServices();
builder.Services.AddIdentityServices(configuration);
builder.Services.AddInfrastructureServices(configuration);
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
builder.Services.AddPayOSService(builder.Configuration);
builder.Services.AddChatNotification(); //extension method


//builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();

    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,  // Use HTTP scheme for Bearer token
        Scheme = "bearer", // The scheme to use for authorization
        BearerFormat = "JWT",  // Indicating that it's a JWT token
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter your JWT token here without the Bearer prefix. Example: 'your_token_here'"
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        }
    });
});

// Cấu hình CORS cho phép tất ca
builder.Services.AddCors(options =>
{
    options.AddPolicy("all", policy =>
    {
        policy.AllowAnyOrigin()  // Cho phép bất kỳ nguồn nào
              .AllowAnyMethod()  // Cho phép mọi phương thức HTTP (GET, POST, PUT, DELETE, v.v.)
              .AllowAnyHeader(); // Cho phép bất kỳ header nào
    });
});
builder.Services.AddScoped<GoalService>();

builder.Services.AddHttpClient("n8n", client =>
{
    client.BaseAddress = new Uri("https://n8n.persiehomeserver.com/");
});

var app = builder.Build();

app.UseRouting(); // Thêm UseRouting


// Kiểm tra môi trường và cấu hình Swagger
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging(); // Đăng nhập các yêu cầu
app.UseCors("all");  // Sử dụng CORS policy
app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection(); // Chuyển hướng HTTP sang HTTPS

// Cấu hình Authorization và Authentication
app.UseAuthentication();
app.UseAuthorization();
app.MapHub<SignalRHub>("/chat/mon-ai");
app.MapHub<ChatHub>("/chatbox");

// Map Controllers cho các API endpoints
app.MapControllers();

// Thực thi các migration cho cơ sở dữ liệu
app.MigrationDatabase();

// Chạy ứng dụng
app.Run();
