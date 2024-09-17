namespace Api.Models
{
    public class PerfilModel
    {
        public int PerfilId { get; set; }

        public string PerfilFoto { get; set; } = string.Empty;

        public int CadastroId { get; set; }


        public static implicit operator List<object>(PerfilModel v)
        {
            throw new NotImplementedException();
        }
    }
}
