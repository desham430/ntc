using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ntc.Controllers
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

        public ActionResult Employeeinfo()
        {
            return View();
        }

        public ActionResult helperdemo()
        {
            return View();
        }

        public ActionResult layoutfiles()
        {

            return View();
        }

        public ActionResult layoutfile2()
        {

            return View();

        }
        public ActionResult referlayout()
        {

            return View();

        }
        public ActionResult partialviewdemo()
        {

            return View();

        }
    }
}