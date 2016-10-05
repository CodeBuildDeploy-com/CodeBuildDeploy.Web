using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyWebSite.DataAccess
{
    public class DAContext : DbContext
    {
        public DAContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer<DbContext>(null);
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
