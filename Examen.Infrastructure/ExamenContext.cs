using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext: DbContext
    {
        public DbSet<Batiment> Batiments { get; set; }
        public DbSet<Citoyen> Citoyens { get; set; }
        public DbSet<Domicile> Domiciles { get; set; }
        public DbSet<Domicilaition> Domicilaitions { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=ExamenDB;Integrated Security=true ;MultipleActiveResultSets = True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BatimentConfiguration());
            modelBuilder.ApplyConfiguration(new DomiciliationConfiguration());

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

    }
}