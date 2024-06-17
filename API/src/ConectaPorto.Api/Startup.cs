using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using ConectaPorto.Services.EntityService.Interfaces;
using ConectaPorto.Services.EntityService;

namespace ConectaPorto.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Configuração do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("Usuario", new OpenApiInfo { Title = "Usuario", Version = "v1" });
                c.SwaggerDoc("Administrador", new OpenApiInfo { Title = "Administrador", Version = "v1" });
                c.SwaggerDoc("Utilitarios", new OpenApiInfo { Title = "Utilitarios", Version = "v1" });
            });

            var connectionString = _configuration.GetConnectionString("OracleConnection");
            /*services.AddDbContext<ConectaPortoDbContext>(options =>
            options.UseOracle(_configuration.GetConnectionString("OracleConnection");, b => 
            b.MigrationsAssembly("ConectaPorto.Api")
            ));*/
            services.AddDbContext<DbContext,ConectaPortoDbContext>(builder => 
            builder.UseOracle(connectionString, b => b.MigrationsAssembly("ConectaPorto.Api")));

            CheckOracleConnection();

            RegisterServices.Register(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/Usuario/swagger.json", "Usuario");
                    c.SwaggerEndpoint("/swagger/Administrador/swagger.json", "Administrador");
                    c.SwaggerEndpoint("/swagger/Utilitarios/swagger.json", "Utilitarios");
                });
            }

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void CheckOracleConnection()
        {
            var connectionString = _configuration.GetConnectionString("OracleConnection");

            using (var connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão com o banco de dados Oracle estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    // Lidar com a exceção (por exemplo, logar ou enviar uma resposta de erro)
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }
        }

    }
}
