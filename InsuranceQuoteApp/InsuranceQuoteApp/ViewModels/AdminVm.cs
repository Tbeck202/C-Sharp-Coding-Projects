﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuoteApp.ViewModels
{
    public class AdminVm
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal TotalQuote { get; set; }
    }
}