namespace Api.Models
{
    public class CadastroModel
    {
        public int CadastroId { get; set; }
        public string CadastroNomeCompleto { get; set; } = string.Empty;
        public string CadastroDataNascimento { get; set; } = string.Empty;

        public string CadastroFoto { get; set; } = string.Empty;
        public string CadastroRm { get; set; } = string.Empty;
        public string CadastroCurso { get; set; } = string.Empty;
        public string CadastroEmail { get; set; } = string.Empty;
        public string CadastroSenha { get; set; } = string.Empty;
        public string CadastroEndereço { get; set; } = string.Empty;

        public int FaculdadeId { get; set; }


        public static implicit operator List<object>(CadastroModel v)
        {
            throw new NotImplementedException();
        }
    }
}
