using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class DUICostCalculator
    {
        public decimal getCostBecauseOfDUI(bool haveDUI, decimal runningTotalQuote)
        {
            decimal extraCostBecauseOfDUI = 0.00m;
            if (haveDUI == true)
            {
                extraCostBecauseOfDUI = runningTotalQuote * 0.25m;
            }
            return extraCostBecauseOfDUI;
        }
    }
}