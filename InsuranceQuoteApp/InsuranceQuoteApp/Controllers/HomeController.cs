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

        [HttpPost]
        public ActionResult Quote(
            string firstName, string lastName, string email, DateTime dob, int carYear, string carMake, string carModel, bool dui, int speedTick, bool coverage)
        {
            return View("~/Views/Home/Index");
        }
    }
}

//public ActionResult about()
//{
//    ViewBag.message = "your application description page.";

//    return View();
//}

//public ActionResult contact()
//{
//    ViewBag.message = "your contact page.";

//    return View();
//}