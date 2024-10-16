namespace Api.Models
{
    public class CaronaModel
    {
        public int CaronaId { get; set; }
        public DateTime CaronaHorario { get; set; } 
        public string CaronaVagas { get; set; } = string.Empty;
        public string CaronaVeiculo { get; set; } = string.Empty;
        public string CaronaOrigem { get; set; } = string.Empty;
        public string CaronaDestino { get; set; } = string.Empty;
        public int CaronaTipoId { get; set; }
        public int CadastroId { get; set; }

        public static implicit operator List<object>(CaronaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
