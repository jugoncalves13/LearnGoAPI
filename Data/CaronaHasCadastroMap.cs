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
            builder.HasKey(x => x.CaronaId);
            builder.HasKey(x => x.CadastroId);


        }
    }
}
