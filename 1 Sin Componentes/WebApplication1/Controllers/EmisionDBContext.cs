using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.Models
{
    public class EmisionDBContext : DbContext
    {
        public DbSet<Emision> Emisiones { get; set; } 
        public DbSet<Certificado> Certificados { get; set; }

        static EmisionDBContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmisionDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}