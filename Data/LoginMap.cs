using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class LoginMap : IEntityTypeConfiguration<LoginModel>
    {
        public void Configure(EntityTypeBuilder<LoginModel> builder)
        {
            builder.HasKey(x => x.LoginId);
            builder.Property(x => x.LoginEmail).IsRequired().HasMaxLength(255);
            builder.Property(x => x.LoginSenha).IsRequired().HasMaxLength(255);

        }
    }
}
