using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuoteApp.ViewModels
{
    public class QuoteVm
    {
        public decimal? totalQuote;

        //public string TotalQuote { get; set; }

        //public QuoteVm(decimal totalQuote)
        //{
        //    this.TotalQuote = totalQuote.ToString();
        //}

        public QuoteVm(decimal? totalQuote)
        {
            this.totalQuote = totalQuote;
        }
    }
}