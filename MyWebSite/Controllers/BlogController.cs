using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using MyWebSite.DataAccess;
    using MyWebSite.Models;
    using MyWebSite.Repositories;

    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogsRepository;

        public BlogController(IBlogRepository blogsRepository)
        {
            _blogsRepository = blogsRepository;
        }

        public ActionResult ViewBlogEntry(string title)
        {
            var viewModel = new BlogsViewModel(_blogsRepository, 1);
            IList<Post> posts = viewModel.Posts.Where(p => p.Title.ToLower().Equals(title.ToLower())).ToList();
            Post post = posts[0];

            ViewBag.Title = post.Title;
            ViewBag.Message = post.Description;

            return View(post);
        }

        public ActionResult Tools()
        {
            return View();
        }

        public ActionResult Links()
        {
            return View();
        }

        public ActionResult PowerShellRemoting()
        {
            return View();
        }

        public ActionResult PowerShellGrep()
        {
            return View();
        }
    }
}