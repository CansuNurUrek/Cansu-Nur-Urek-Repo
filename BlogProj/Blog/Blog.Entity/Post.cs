using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? Url { get; set; }
        public string? ImgUrl { get; set; }
        public List<PostCategories> PostCategories { get; set; } = null!;

    }
}
