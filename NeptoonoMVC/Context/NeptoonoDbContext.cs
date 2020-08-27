using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NeptoonoMVC.Models;

namespace NeptoonoMVC.Context
{
    public class NeptoonoDbContext:DbContext
    {
        public NeptoonoDbContext():base("MiConexion")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<NeptoonoDbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Pais> Paises { get; set; }
    }
}