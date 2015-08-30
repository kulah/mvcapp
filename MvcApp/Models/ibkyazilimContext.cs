using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MvcApp.Models.Mapping;

namespace MvcApp.Models
{
    public partial class ibkyazilimContext : DbContext
    {
        static ibkyazilimContext()
        {
            Database.SetInitializer<ibkyazilimContext>(null);
        }

        public ibkyazilimContext()
            : base("Name=ibkyazilimContext")
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
