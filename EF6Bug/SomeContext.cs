using System.Data.Entity;

namespace EF6Bug
{
    public class SomeContext : DbContext
    {
        public virtual DbSet<SomeModel> SomeModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("NotDbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}
