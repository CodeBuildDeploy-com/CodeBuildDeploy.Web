﻿using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class ErrorController : Controller
    {
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