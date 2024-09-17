namespace Api.Models
{
    public class FaculdadeModel
    {
        public int FaculdadeId { get; set; }

        public string FaculdadeNome { get; set; } = string.Empty;

        public string FaculdadeCidade { get; set; } = string.Empty;


        public static implicit operator List<object>(FaculdadeModel v)
        {
            throw new NotImplementedException();
        }
    }
}
