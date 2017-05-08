using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Message = "歡迎使用 ASP.NET";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        /*
         * 
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }       

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }        

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

         
         
         
         
         
         */
    }
}
