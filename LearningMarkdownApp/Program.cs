using LearningMarkdownApp.Models.Context;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LearningMarkdownApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHost(args).Run();
        }

        public static IWebHost CreateHost(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<MainContext>();

                dbContext.Database.Migrate();
            }

            return host;
        }
    }
}
