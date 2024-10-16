namespace Api.Models
{
    public class CaronaTipoModel
    {
        public int CaronaTipoId { get; set; }

        public string CaronaTipoDescricao { get; set; } = string.Empty;

        public static implicit operator List<object>(CaronaTipoModel v)
        {
            throw new NotImplementedException();
        }
    }
}
