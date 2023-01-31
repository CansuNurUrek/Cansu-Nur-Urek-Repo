using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IPostService
    {
        //Task<List<Post>> GetAllPostsAsync( );
        //List<Post> GetAll();
        //Post GetById(int id);

        //void Update(Post entity);
        //void Delete(Post entity);
        List<Post> GetHomePosts();
        List<Post> GetPostsByCategory(string category);
       List<Post> PostsInCategory(int id);
        Post GetDetails(int id);

    }
}
