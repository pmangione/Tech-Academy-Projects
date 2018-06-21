using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class AgeCostCalculator
    {
        public decimal getExtraCostBecauseOfAge(int age)
        {
            Decimal extraCostBecauseOfAge = 0.00m;
            if (age < 25)
            {
                extraCostBecauseOfAge = 25.00m;
            }
            if (age < 18)
            {
                extraCostBecauseOfAge = 100.00m;
            }
            if (age > 100)
            {
                extraCostBecauseOfAge = 25.00m;
            }
            return extraCostBecauseOfAge;

        }
    }
}