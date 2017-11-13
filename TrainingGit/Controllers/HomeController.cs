using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int one=0, int two=0)
        {
            int result = one + two;
            ViewBag.result = result;
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
    }
}