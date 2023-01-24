namespace ProjectCoffe.Models
{
    public class Organizacao
    {
        public Organizacao(int id, string semana)
        {
            Id = id;
            Semana = semana;
        }

        public int Id { get; set; }
        public string Semana { get; set; }
    }
}
