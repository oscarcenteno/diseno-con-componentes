using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Models.Certificados;

namespace DS
{
    public class EmisionDBContext : DbContext
    {
        public DbSet<RegistroDeEmision> Emisiones { get; set; } 
        public DbSet<RegistroDeCertificado> Certificados { get; set; }
        public DbSet<RegistroDeParametro> Parametros { get; set; }

        static EmisionDBContext()
        {
            Database.SetInitializer(new EmisionDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}