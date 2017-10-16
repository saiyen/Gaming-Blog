using System;
using System.Collections.Generic;
using System.Text;

namespace sikhs.Core.Objects
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string UrlSlug { get; set; }

        public string Description { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}
