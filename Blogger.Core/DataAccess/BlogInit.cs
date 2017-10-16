using sikhs.Core.Objects;
using System.Collections.Generic;
using System.Data.Entity;

namespace sikhs.Core.DataAccess
{
    class BlogInit : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var posts = new List<Post>
            {
                new Post{},
            };
            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category{},
            };
            categories.ForEach(c => context.Category.Add(c));
            context.SaveChanges();

            var tags = new List<Tag>
            {
                new Tag{},
            };
            tags.ForEach(t => context.Tags.Add(t));
            context.SaveChanges();
        }
    }
}
