using Blog.Entity;

namespace Blog.Proj.Model
{
    public class PostCategoryModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Post> Posts { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;

        public string selectedCategory { get; set; }

    }
}
