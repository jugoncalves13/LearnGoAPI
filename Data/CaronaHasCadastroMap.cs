using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class CaronaHasCadastroMap : IEntityTypeConfiguration<CaronaHasCadastroModel>
    {
        public void Configure(EntityTypeBuilder<CaronaHasCadastroModel> builder)
        {
            builder.HasKey(x => x.CaronaHasCadastroId);
            builder.Property(x => x.CaronaId).IsRequired();
            builder.Property(x => x.CadastroId).IsRequired();


        }
    }
}
