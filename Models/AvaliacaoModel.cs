namespace Api.Models
{
    public class AvaliacaoModel
    {
        public int AvaliacaoId { get; set; }

        public string AvaliacaoQuemAvaliou { get; set; } = string.Empty;

        public string AvaliacaoAvaliado { get; set; } = string.Empty;
        public string AvaliacaoComentario { get; set; } = string.Empty;

        public int CadastroId { get; set; }

        public static implicit operator List<object>(AvaliacaoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
