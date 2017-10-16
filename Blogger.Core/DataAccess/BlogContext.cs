using sikhs.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace sikhs.Core.DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
        }

        // Maakt tabellen van models
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tags { get; set; }

        // Maakt enkelvoud van de tabelnamen
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}