using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuoteApp.Models
{
    public class BuildQuote
    {
        public static decimal Calculate(Quote quote)
        {
            decimal quoteTotal = 50;
            DateTime quoteDay = DateTime.Now;
            int userAge = Convert.ToInt32(quoteDay.Year - quote.Dob.Year);
            if (userAge < 25 || userAge > 100)
            {
                quoteTotal += 25;
            }
            if (userAge < 18)
            {
                quoteTotal += 100;
            }
            if (quote.CarYear < 2000 || quote.CarYear > 2015)
            {
                quoteTotal += 25;
            }
            if (quote.CarMake.ToLower() == "porsche")
            {
                quoteTotal += 25;
            }
            if (quote.CarModel.ToLower() == "911 carrera")
            {
                quoteTotal += 25;
            }
            if (quote.SpeedTick > 0)
            {
                quoteTotal += quote.SpeedTick * 10;
            }
            if (quote.Dui == true)
            {
                quoteTotal = quoteTotal * 1.25m;
            }
            if (quote.Coverage == true)
            {
                quoteTotal = quoteTotal * 1.5m;
            }
             
            return quoteTotal;
        }
    }
}