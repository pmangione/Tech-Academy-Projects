using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class SpeedingTicketCostCalculator
    {
        public decimal getCostBecauseOfNumberOfSpeedingTickets(int numberSpeedingTickets)
        {
            decimal costPerSpeedingTicket = 10.00m;
            decimal extraCostBecauseOfNumberOfSpeedingTickets = costPerSpeedingTicket * numberSpeedingTickets;
            return extraCostBecauseOfNumberOfSpeedingTickets;
        }

    }
}