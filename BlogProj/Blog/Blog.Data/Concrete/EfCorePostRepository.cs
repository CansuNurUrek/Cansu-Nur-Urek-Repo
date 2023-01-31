using Blog.Data.Abstract;
using Blog.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Data.Concrete
{

    public class EfCorePostRepository : EfCoreGenericRepository<Post>, IPostRepository
    {

        public EfCorePostRepository(BlogContext _dbContext) : base(_dbContext)
        {

        }

        private BlogContext context
        {
            get
            {
                return _dbContext as BlogContext;
            }
        }

        public Post GetDetails(int id)
        {
            return context
                 .Posts
                 .Where(p => p.Id == id)
                 .Include(p => p.PostCategories)
                 .ThenInclude(pc => pc.Category)
                 .FirstOrDefault();
        }

        public List<Post> GetHomePosts()
        {            
            return context
                .Posts
                
                .ToList();
        }

        public List<Post> GetPostsByCategory(string category)
        {
            var posts = context.Posts.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                posts = posts
                    
                    .Include(p => p.PostCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(p => p.PostCategories.Any(pc => pc.Category.Url == category));
               
            };
            
            return posts.ToList();


        }

        public List<Post> PostsInCategory(int id)
        {
            return context
                 .Posts
                 
                 .Include(p => p.PostCategories)
                 .ThenInclude(pc => pc.Category)
                 .Where(pc => pc.PostCategories.Any(pc => pc.Category.Id == id))
                .ToList();

          
        }
    }
        
}
