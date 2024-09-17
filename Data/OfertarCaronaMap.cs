using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class OfertarCaronaMap : IEntityTypeConfiguration<OfertarCaronaModel>
    {
        public void Configure(EntityTypeBuilder<OfertarCaronaModel> builder)
        {
            builder.HasKey(x => x.OfertarCaronaId);
            builder.Property(x => x.OfertarCaronaPeriodo).IsRequired().HasMaxLength(255);
            builder.Property(x => x.OfertarCaronaHorário).IsRequired().HasMaxLength(255);
            builder.Property(x => x.OfertarCaronaEndereço).IsRequired().HasMaxLength(255);
            builder.Property(x => x.OfertarCaronaVagas).IsRequired().HasMaxLength(255);
            builder.Property(x => x.OfertarCaronaVeiculo).IsRequired().HasMaxLength(255);
        }
    }
}
