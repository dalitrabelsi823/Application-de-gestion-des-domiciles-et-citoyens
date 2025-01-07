using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext: DbContext
    {
        public DbSet<Exemple> Exemples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=ExamenDB;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

    }
}