using Blog.Business.Abstract;
using Blog.Data.Abstract;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class PostManager : IPostService
    {

      
        private IPostRepository _postRepository;
        private ICategoryRepository _categoryRepository;
        public PostManager(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;

        }

     

        public List<Post> GetHomePosts()
        {
            return _postRepository.GetHomePosts();
        }

        public List<Post> GetPostsByCategory(string category)
        {
            return _postRepository.GetPostsByCategory(category);

        }

        public List<Post> PostsInCategory(int id)
        {
            return _postRepository.PostsInCategory(id);
        }

        public Post GetDetails(int id)
        {
            return _postRepository.GetDetails(id);
        }
    }
}
