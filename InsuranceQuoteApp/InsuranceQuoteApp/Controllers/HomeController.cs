using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apply()
        {
            return View();
        }

        public ActionResult about()
        {
            ViewBag.message = "your application description page.";

            return View();
        }

        public ActionResult contact()
        {
            ViewBag.message = "your contact page.";

            return View();
        }
    }
}