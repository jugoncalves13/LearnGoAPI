using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class SolicitarCaronaMap : IEntityTypeConfiguration<SolicitarCaronaModel>
    {
        public void Configure(EntityTypeBuilder<SolicitarCaronaModel> builder)
        {
            builder.HasKey(x => x.SolicitarCaronaId);
            builder.Property(x => x.SolicitarCaronaNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.SolicitarCaronaHorário).IsRequired().HasMaxLength(255);
            builder.Property(x => x.SolicitarCaronaEndereço).IsRequired().HasMaxLength(255);
            builder.HasKey(x => x.FaculdadeId);

        }
    }
}
