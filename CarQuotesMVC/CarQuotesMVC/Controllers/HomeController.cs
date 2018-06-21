using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarQuotesMVC.Models;
using CarQuotesMVC.ViewModels;

namespace CarQuotesMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnterCarInfo(string firstname, string lastname, string email, string dob, string caryear, string carmake, string carmodel, string numberspeedingtickets, string fullorliability, string dui)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(carmake) || string.IsNullOrEmpty(carmodel) || string.IsNullOrEmpty(fullorliability) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(caryear) || string.IsNullOrEmpty(numberspeedingtickets) || string.IsNullOrEmpty(dui))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CarQuoteDBEntities db = new CarQuoteDBEntities())
                {
                    var carquote = new CarQuote();
                    carquote.FirstName = firstname;
                    carquote.LastName = lastname;
                    carquote.Email = email;
                    carquote.DOB = Convert.ToDateTime(dob);
                    carquote.CarYear = Convert.ToInt32(caryear);
                    carquote.CarMake = carmake;
                    carquote.CarModel = carmodel;
                    carquote.DUI = Convert.ToBoolean(dui);
                    carquote.NumberSpeedingTickets = Convert.ToInt32(numberspeedingtickets);
                    carquote.FullOrLiability = fullorliability;
                    var quotecalculator = new QuoteCalculator();
                    carquote.Quote = quotecalculator.GetQuote(carquote);
                    db.CarQuotes.Add(carquote);
                    db.SaveChanges();
                    return View("ShowQuote", carquote);
                }
                    
            }
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}