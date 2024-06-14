using ConectaPorto.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace ConectaPorto.Api
{
    public class Program
    {
        private readonly IConfiguration _config;
        public Program(IConfiguration config)
        {
            _config = config;
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
