// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.Extensions.Configuration;

// namespace Monhealth.Identity.Dbcontexts
// {
//     public class MonhealthContextFactory : IDesignTimeDbContextFactory<MonhealthDbcontext>
//     {
//         public MonhealthDbcontext CreateDbContext(string[] args)
//         {
//             var configuration = new ConfigurationBuilder()
//                                    .SetBasePath(Directory.GetCurrentDirectory())
//                                    .AddJsonFile($"appsettings.Production.json", optional: true)
//                                    .AddJsonFile($"appsettings.Development.json", optional: true)
//                                    .Build();
//             var builder = new DbContextOptionsBuilder<MonhealthDbcontext>();
//             builder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
//             return new MonhealthDbcontext(builder.Options);
//         }
//     }
// }
