namespace Api.Models
{
    public class AvaliacaoModel
    {
        public int AvaliacaoId { get; set; }
        public int CadastroId { get; set; }
        public int CaronaId { get; set; }
        public string AvaliacaoComentario { get; set; } = string.Empty;

        public static implicit operator List<object>(AvaliacaoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
