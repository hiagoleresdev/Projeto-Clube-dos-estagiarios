using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Infrastructure
{
    public class ClubeDbContext: DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; } = null!;
        public DbSet<Socio> Socios { get; set; } = null!;
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Mensalidade> Mensalidades { get; set; } = null!;
        public DbSet<Dependente> Dependentes { get; set; } = null!;

        public ClubeDbContext(DbContextOptions<ClubeDbContext> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
