using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MvcApp.Models.Mapping;

namespace MvcApp.Models
{
    public partial class ibkyazil_mssqlContext : DbContext
    {
        static ibkyazil_mssqlContext()
        {
            Database.SetInitializer<ibkyazil_mssqlContext>(null);
        }

        public ibkyazil_mssqlContext()
            : base("Name=ibkyazil_mssqlContext")
        {
        }

        public DbSet<TAN_KURUM> TAN_KURUM { get; set; }
        public DbSet<USERLIST> USERLISTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TAN_KURUMMap());
            modelBuilder.Configurations.Add(new USERLISTMap());
        }
    }
}
