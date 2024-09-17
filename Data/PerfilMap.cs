using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class PerfilMap : IEntityTypeConfiguration<PerfilModel>
    {
        public void Configure(EntityTypeBuilder<PerfilModel> builder)
        {
            builder.HasKey(x => x.PerfilId);
            builder.Property(x => x.PerfilFoto).IsRequired().HasMaxLength(255);
            builder.HasKey(x => x.CadastroId);


        }
    }
}
