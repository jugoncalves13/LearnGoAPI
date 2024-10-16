using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class AvaliacaoMap : IEntityTypeConfiguration<AvaliacaoModel>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoModel> builder)
        {
            builder.HasKey(x => x.AvaliacaoId);
            builder.Property(x => x.CadastroId).IsRequired();
            builder.HasKey(x => x.CaronaId);
            builder.Property(x => x.AvaliacaoComentario).IsRequired().HasMaxLength(255);
           
        }
    }
}
