using Monhealth.Api.GlobalException;
using Monhealth.Application;
using Monhealth.Application.Models.Phone;
using Monhealth.Application.ServiceForRecommend;
using Monhealth.Application.Services;
using Monhealth.Identity;
using Monhealth.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var twilioSettings = builder.Configuration.GetSection("Twilio").Get<TwilioSettings>();
builder.Services.AddSingleton(twilioSettings);

//add serilog
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddIdentityServices(configuration);
builder.Services.AddInfrastructureServices(configuration);
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("ApiKey", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter your token here without the Bearer prefix. Example: 'your_token'"
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new string[] { }
        }
    });
});
builder.Services.AddScoped<FoodFilterService>();
builder.Services.AddScoped<GoalService>();
builder.Services.AddScoped<FoodRandomService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Add Swagger services
var app = builder.Build();

// var urls = app.Urls.Any() ? string.Join(", ", app.Urls) : "http://localhost:8081";
// Log.Information("Now listening on: {Urls}", urls);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSerilogRequestLogging();
app.UseCors("all");
app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    var authorizationHeader = context.Request.Headers["Authorization"].FirstOrDefault();
    if (!string.IsNullOrEmpty(authorizationHeader) && !authorizationHeader.StartsWith("Bearer "))
    {
        context.Request.Headers["Authorization"] = $"Bearer {authorizationHeader}";
    }
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MigrationDatabase();
app.Run();
