using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP_EmergencyBackend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "System To Monitor The Accidents Which Occure Right Now.";

            return View();
        }
            
        public ActionResult About()
        {
            ViewBag.Message = "The System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Developers Contacts";

            return View();
        }
    }
}
