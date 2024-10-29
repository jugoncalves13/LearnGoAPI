using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<FaculdadeModel> Faculdade { get; set; }
        public DbSet<AvaliacaoModel> Avaliacao { get; set; }
        public DbSet<CadastroModel> Cadastro { get; set; }
        public DbSet<CaronaModel> Carona { get; set; }
        public DbSet<CaronaHasCadastroModel> CaronaHasCadastro { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroMap());
            modelBuilder.ApplyConfiguration(new FaculdadeMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new CaronaMap());
            modelBuilder.ApplyConfiguration(new CaronaHasCadastroMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
