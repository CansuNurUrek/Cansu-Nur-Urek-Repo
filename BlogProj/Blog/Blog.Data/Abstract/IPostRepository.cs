using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    public interface IPostRepository : IRepository<Post>

    {

        List<Post> GetHomePosts();
        List<Post> GetPostsByCategory(string category);
        List<Post> PostsInCategory(int id);

        Post GetDetails(int id);

    }
}
