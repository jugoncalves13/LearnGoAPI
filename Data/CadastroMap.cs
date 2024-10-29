using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class CadastroMap : IEntityTypeConfiguration<CadastroModel>
    {
        public void Configure(EntityTypeBuilder<CadastroModel> builder)
        {
            builder.HasKey(x => x.CadastroId);
            builder.Property(x => x.CadastroNomeCompleto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroFoto).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroDataNascimento).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroRm).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroCurso).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroEmail).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroSenha).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CadastroEndereço).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FaculdadeId).IsRequired();
        }

    }
}
