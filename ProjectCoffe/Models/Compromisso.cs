namespace ProjectCoffe.Models
{
    public class Compromisso
    {
        public Compromisso(int pessoaId, int organizacaoId)
        {
            PessoaId = pessoaId;
            OrganizacaoId = organizacaoId;
        }

        public Pessoa? Pessoa { get; set; }
        public int PessoaId { get; set; }
        public Organizacao? Organizacao { get; set; }
        public int OrganizacaoId { get; set; }
    }
}
