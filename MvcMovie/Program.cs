using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using System;


namespace MvcMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //CreateHostBuilder(args).Build().Run();

            //creates a generic host. and builds the app
            var host = CreateHostBuilder(args).Build();

            //createa scope to  ...
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;//create a scope for the service provider.
                try
                {
                    SeedData.Initialize(services);//seed the Db with the STATIC method
                }
                catch (Exception ex)
                {
                    //log if an exception occurs.
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An exception happened in the seeding of the DB.");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
