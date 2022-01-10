
using ClubeApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClubeApi.Infraestruture
{
    public class ClubeDbContext: DbContext
    {
        public ClubeDbContext() {}

        public ClubeDbContext(DbContextOptions<ClubeDbContext> opcoes) : base(opcoes) { }


        public DbSet<Socio> Socios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }


    }
}
