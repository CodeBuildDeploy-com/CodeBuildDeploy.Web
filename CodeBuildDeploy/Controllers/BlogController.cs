using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.DataAccess;
using CodeBuildDeploy.Models;
using CodeBuildDeploy.Repositories;

namespace CodeBuildDeploy.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        private readonly IBlogRepository _blogsRepository;

        public BlogController(ILogger<BlogController> logger, IBlogRepository blogsRepository)
        {
            _logger = logger;
            _blogsRepository = blogsRepository;
        }

        public ActionResult ViewBlogEntry(string urlSlug)
        {
            var viewModel = new BlogsViewModel(_blogsRepository, 1);
            IList<Post> posts = viewModel.Posts.Where(p => p.UrlSlug.ToLower().Equals(urlSlug.ToLower())).ToList();
            Post post = posts[0];

            ViewBag.Title = post.Title;
            ViewBag.Message = post.Description;

            _logger.LogInformation("Viewing Blog: '{0}'", post.Title);

            return View(post);
        }
    }
}