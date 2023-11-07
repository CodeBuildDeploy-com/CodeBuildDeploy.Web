using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        // GET: Error
        public ActionResult Index()
        {
            return View("Error", "_LayoutBasic");
        }

        // GET: Error
        public ActionResult NotFound()
        {
            return View("NotFound", "_LayoutBasic");
        }
    }
}