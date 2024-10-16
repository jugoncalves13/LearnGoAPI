namespace Api.Models
{
    public class CaronaHasCadastroModel
    {
        public int CaronaHasCadastroId { get; set; }
        public int CaronaId { get; set; }
        public int CadastroId { get; set; }


        public static implicit operator List<object>(CaronaHasCadastroModel v)
        {
            throw new NotImplementedException();
        }
    }
}
