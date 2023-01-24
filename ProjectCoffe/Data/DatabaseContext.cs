using Microsoft.EntityFrameworkCore;
using ProjectCoffe.Models;

namespace ProjectCoffe.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Compromisso> Compromissos { get; set; }
        public DbSet<Organizacao> Organizacaos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
