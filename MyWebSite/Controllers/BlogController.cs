using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    using MyWebSite.Models;
    using MyWebSite.Repositories;

    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogsRepository;

        public BlogController(IBlogRepository blogsRepository)
        {
            _blogsRepository = blogsRepository;
        }

        public ActionResult PowerShellRemoting()
        {
            var viewModel = new BlogsViewModel(_blogsRepository, 1);
            return View(viewModel);
        }

        public ActionResult PowerShellGrep()
        {
            return View();
        }
    }
}