﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider.Web.Mvc.Filters;

namespace MvcSiteMapProvider_236.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            

            return View();
        }

        [SiteMapTitle("TitleKey")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            ViewData["TitleKey"] = "This is the title";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
