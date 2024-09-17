namespace Api.Models
{
    public class SolicitarCaronaModel
    {
        public int SolicitarCaronaId { get; set; }

        public string SolicitarCaronaNome { get; set; } = string.Empty;

        public DateTime SolicitarCaronaHorário { get; set; }
        public string SolicitarCaronaEndereço { get; set; } = string.Empty;

        public int FaculdadeId { get; set; }

        public static implicit operator List<object>(SolicitarCaronaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
