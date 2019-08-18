using InsuranceQuoteApp.Models;
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

            Quote newQuote = new Quote();
            newQuote.FirstName = firstName;
            newQuote.LastName = lastName;
            newQuote.Email = email;
            newQuote.Dob = dob;
            newQuote.CarYear = carYear;
            newQuote.CarMake = carMake;
            newQuote.CarModel = carModel;
            newQuote.Dui = dui;
            newQuote.SpeedTick = speedTick;
            newQuote.Coverage = coverage;


            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                newQuote.TotalQuote = BuildQuote.Calculate(newQuote);

                var quote = new Quote();
                quote.FirstName = firstName;
                quote.LastName = lastName;
                quote.Email = email;
                quote.Dob = dob;
                quote.CarYear = carYear;
                quote.CarMake = carMake;
                quote.CarModel = carModel;
                quote.Dui = dui;
                quote.SpeedTick = speedTick;
                quote.Coverage = coverage;
                quote.TotalQuote = newQuote.TotalQuote;


                db.Quotes.Add(quote);
                db.SaveChanges();
            }
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