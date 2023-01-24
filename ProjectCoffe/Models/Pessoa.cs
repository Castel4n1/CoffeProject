namespace ProjectCoffe.Models
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string setor)
        {
            Id = id;
            Nome = nome;
            Setor = setor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }

        //relacionamentos
        public List<Compromisso> Compromissos { get; set; }
    }   
}
