using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class CaronaMap : IEntityTypeConfiguration<CaronaModel>
    {
        public void Configure(EntityTypeBuilder<CaronaModel> builder)
        {
            builder.HasKey(x => x.CaronaId);
            builder.Property(x => x.CaronaHorario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CaronaVagas).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CaronaVeiculo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CaronaOrigem).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CaronaDestino).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroId).IsRequired();
        }
    }
}
