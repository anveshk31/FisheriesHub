using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FisheriesHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tab1()
        {
            ViewBag.Message = "Waiting for content";

            return View();
        }

        public ActionResult Tab2()
        {
            ViewBag.Message = "Waiting for content again";

            return View();
        }
    }
}