using Blog.Business.Abstract;
using Blog.Entity;
using Blog.Proj.Model;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Proj.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public HomeController(IPostService postService, ICategoryService categoryService)
        {
            _postService = postService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {

            List<Post> homePosts = _postService.GetHomePosts();
            List<Category> homeCategories = _categoryService.GetAll();


            PostModel viewModel = new PostModel()
            {
                Posts = homePosts,
                Categories = homeCategories
            };

          
            return View(viewModel);
        }

        public IActionResult List(string category)
        {
            List<Post> posts = _postService.GetPostsByCategory(category);

         

            PostCategoryModel postCategoryModel = new PostCategoryModel()
            {
                Posts = posts,
             
            };
            return View(postCategoryModel);
        }

        public IActionResult PostsInCategory(int id)
        {
            var posts = _postService.PostsInCategory(id);
            var categories = _categoryService.GetAll();

            var selectedCategory = categories.Where(e => e.Id == id).FirstOrDefault();


            PostCategoryModel model = new PostCategoryModel()
            {
                Posts = posts,
                Categories = categories,
                selectedCategory = selectedCategory.Name
            };
            return View(model);

        }


        public IActionResult Details(int id)
        {
            var detail = _postService.GetDetails(id);
            PostCategoryModel model = new PostCategoryModel();
        

            return View(model);

        }
    }
}
