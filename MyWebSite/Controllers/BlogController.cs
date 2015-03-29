using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    using MyWebSite.DataAccess;
    using MyWebSite.Models;
    using MyWebSite.Repositories;

    public class BlogController : Controller
    {
        public ActionResult PowerShellRemoting()
        {
            var viewModel = new BlogsViewModel(new BlogRepository(new DAContext()), 1);
            return View(viewModel);
        }

        public ActionResult PowerShellGrep()
        {
            return View();
        }
    }
}