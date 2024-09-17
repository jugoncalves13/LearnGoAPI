namespace Api.Models
{
    public class OfertarCaronaModel
    {
        public int OfertarCaronaId { get; set; }

        public string OfertarCaronaPeriodo { get; set; } = string.Empty;

        public DateTime OfertarCaronaHorário { get; set; } 
        public string OfertarCaronaEndereço { get; set; } = string.Empty;

        public string OfertarCaronaVagas { get; set; } = string.Empty;
        public string OfertarCaronaVeiculo { get; set; } = string.Empty;

        public static implicit operator List<object>(OfertarCaronaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
