using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class FaculdadeMap : IEntityTypeConfiguration<FaculdadeModel>
    {
        public void Configure(EntityTypeBuilder<FaculdadeModel> builder)
        {
            builder.HasKey(x => x.FaculdadeId);
            builder.Property(x => x.FaculdadeNome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FaculdadeCidade).IsRequired().HasMaxLength(255);

        }

    }
}
