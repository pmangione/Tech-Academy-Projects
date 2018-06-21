using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class CarYearCostCalculator
    {
        public decimal getExtraCostBecauseOfCarYear(int caryear)
        {
            decimal extraCostBecauseOfCarYear = 0.00m;
            if (caryear < 2000 || caryear > 2015)
            {
                extraCostBecauseOfCarYear = 25.00m;
            }
            return extraCostBecauseOfCarYear;
        }
    }
}