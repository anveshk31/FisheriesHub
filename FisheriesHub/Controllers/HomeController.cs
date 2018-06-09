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

        public ActionResult Help()
        {
            ViewBag.Message = "Your help page.";

            return View();
        }
        public ActionResult FishingTech()
        {
            ViewBag.Message = "Fishing Trade";

            return View();
        }

        public ActionResult Trade()
        {
            ViewBag.Message = "Trade";

            return View();
        }
    }
}