using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class CaronaTipoMap : IEntityTypeConfiguration<CaronaTipoModel>
    {
        public void Configure(EntityTypeBuilder<CaronaTipoModel> builder)
        {
            builder.HasKey(x => x.CaronaTipoId);
            builder.Property(x => x.CaronaTipoDescricao).IsRequired().HasMaxLength(255);
        }
    }
}
