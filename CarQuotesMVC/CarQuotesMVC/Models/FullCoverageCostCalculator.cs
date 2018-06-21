using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class FullCoverageCostCalculator
    {
        public decimal getCostBecauseOfCoverageType(string coverageType, decimal runningTotalQuote)
        {
            decimal extraCostBecauseOfCoverageType = 0.00m;
            if (coverageType == "Full")
            {
                extraCostBecauseOfCoverageType = runningTotalQuote * 0.50m;
            }
            return extraCostBecauseOfCoverageType;
        }
    }
}