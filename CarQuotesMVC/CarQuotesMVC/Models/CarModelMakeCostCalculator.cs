using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class CarModelMakeCostCalculator
    {
        public decimal getCostBecauseOfCarModelAndMake(string model, string make)
        {
            decimal extraCostBecauseOfCarModelAndMake = 0.00m;
            if (make == "Porsche")
            {
                extraCostBecauseOfCarModelAndMake = 25.00m;
            }
            if (make == "Porsche" && model == "911 Carrera")
            {
                extraCostBecauseOfCarModelAndMake = 50.00m;
            }
            return extraCostBecauseOfCarModelAndMake;
            
        }

    }
}