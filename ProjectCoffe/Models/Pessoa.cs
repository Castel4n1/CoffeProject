namespace ProjectCoffe.Models
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Setor { get; set; }

        //relacionamentos
        public List<Compromisso>? Compromissos { get; set; }
    }   
}
