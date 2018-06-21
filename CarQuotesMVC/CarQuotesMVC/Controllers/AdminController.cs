using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarQuotesMVC.ViewModels;

namespace CarQuotesMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarQuoteDBEntities db = new CarQuoteDBEntities())
            {
                var carquotes = db.CarQuotes;
                var carquotesVms = new List<CarQuoteVm>();
                foreach (var carquote in carquotes)
                {
                    var carquoteVm = new CarQuoteVm();
                    carquoteVm.FirstName = carquote.FirstName;
                    carquoteVm.LastName = carquote.LastName;
                    carquoteVm.Email = carquote.Email;
                    carquoteVm.Quote = carquote.Quote;
                    carquotesVms.Add(carquoteVm);
                }
                return View(carquotesVms);

            }

            
        }
    }
}