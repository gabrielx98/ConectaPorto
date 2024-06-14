using ConectaPorto.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System;
using System.IO;

namespace ConectaPorto
{
    public class ConectaPortoDbContext : DbContext
    {
        public ConectaPortoDbContext(DbContextOptions<ConectaPortoDbContext> options) : base(options) { }

        public DbSet<UnitDto> Unit { get; set; }
        public DbSet<UsuarioDto> Usuarios { get; set; }
        public DbSet<CarrierDto> Carrier { get; set; }
        public DbSet<CarrierModeDto> CarrierMode { get; set; }
        public DbSet<ClienteDto> Clientes { get; set; }
        public DbSet<FreightKindDto> FreightKind { get; set; }
        public DbSet<IsoDto> ISO { get; set; }
        public DbSet<PortoDto> Portos { get; set; }
        public DbSet<TransitStateDto> TransitState { get; set; }
        public DbSet<TransportadoraDto> Transportadoras {  get; set; }
        public DbSet<UnitCategoryDto> UnitCategory { get; set; }
        public DbSet<VisitStateDto> VisitState { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Outras configurações de modelo aqui
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConectaPortoDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("../ConectaPorto.Api/appsettings.json")
                    .Build();

                string connectionString = configuration.GetConnectionString("OracleConnection");

                optionsBuilder.UseOracle(connectionString);
            }
        }
    }
}
