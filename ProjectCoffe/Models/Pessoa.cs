using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCoffe.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        //relacionamentos
        public List<Compromisso>? Compromissos { get; set; }
    }   
}
