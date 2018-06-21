using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class QuoteCalculator
    {

        public decimal GetQuote(CarQuote carquote)
        {

            decimal basequote = 50.00m;
            var agefrombirthdaycalculator = new AgeFromBirthdayCalculator();
            var age = agefrombirthdaycalculator.getAgeFromBirthday(Convert.ToDateTime(carquote.DOB));
            var agecostcalculator = new AgeCostCalculator();
            decimal extraCostBecauseOfAge = agecostcalculator.getExtraCostBecauseOfAge(age);
            decimal quote = basequote + extraCostBecauseOfAge;
            var caryearcostcalculator = new CarYearCostCalculator();
            quote += caryearcostcalculator.getExtraCostBecauseOfCarYear(Convert.ToInt32(carquote.CarYear));
            var carmodelmakecostcalculator = new CarModelMakeCostCalculator();
            quote += carmodelmakecostcalculator.getCostBecauseOfCarModelAndMake(carquote.CarModel,carquote.CarMake);
            var speedingticketcostcalculator = new SpeedingTicketCostCalculator();
            quote += speedingticketcostcalculator.getCostBecauseOfNumberOfSpeedingTickets(Convert.ToInt32(carquote.NumberSpeedingTickets));
            var duicostcalculator = new DUICostCalculator();
            quote += duicostcalculator.getCostBecauseOfDUI(Convert.ToBoolean(carquote.DUI),quote);
            var fullcoveragecostcalculator = new FullCoverageCostCalculator();
            quote += fullcoveragecostcalculator.getCostBecauseOfCoverageType(carquote.FullOrLiability, quote);
            return quote;

        }

       
         
    }
}