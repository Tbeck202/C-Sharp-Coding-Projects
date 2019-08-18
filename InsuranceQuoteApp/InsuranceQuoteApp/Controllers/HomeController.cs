using InsuranceQuoteApp.Models;
using InsuranceQuoteApp.ViewModels;
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
                quote.TotalQuote = Math.Round(Convert.ToDecimal(newQuote.TotalQuote), 2);


                db.Quotes.Add(quote);
                db.SaveChanges();
            }
            return View(new QuoteVm(newQuote.TotalQuote));
        }

        public ActionResult Admin()
        {
            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var quotes = db.Quotes;
                var adminVms = new List<AdminVm>();
                foreach (var quote in quotes)
                {
                    var adminVm = new AdminVm();
                    adminVm.FirstName = quote.FirstName;
                    adminVm.LastName = quote.LastName;
                    adminVm.Email = quote.Email;
                    adminVm.TotalQuote = Math.Round(Convert.ToDecimal(quote.TotalQuote), 2);
                    adminVms.Add(adminVm);
                }
                return View(adminVms);
            }
            
        }
    }
}