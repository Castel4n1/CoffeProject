using Microsoft.EntityFrameworkCore;
using ProjectCoffe.Models;

namespace ProjectCoffe.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)

        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compromisso>().HasKey(compro => new
            {
                compro.OrganizacaoId,
                compro.PessoaId
            });
        }
        public DbSet<Compromisso>? Compromissos { get; set; }
        public DbSet<Organizacao>? Organizacaos { get; set; }
        public DbSet<Pessoa>? Pessoas { get; set; }
    }
}
