using System.ComponentModel.DataAnnotations;
using Blog.Entity;

namespace Blog.Proj.Model
{
    public class PostModel
    {
        public int Id { get; set; }
  
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? Url { get; set; }
        public string? ImgUrl { get; set; }        
        public List<Post> Posts { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;


    }
}
