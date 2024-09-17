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
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<OfertarCaronaModel> OfertarCarona { get; set; }
        public DbSet<SolicitarCaronaModel> SolicitarCarona { get; set; }
        public DbSet<PerfilModel> Perfil { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroMap());
            modelBuilder.ApplyConfiguration(new FaculdadeMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new LoginMap());
            modelBuilder.ApplyConfiguration(new OfertarCaronaMap());
            modelBuilder.ApplyConfiguration(new SolicitarCaronaMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
