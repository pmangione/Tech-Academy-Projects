using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WeatherMVC.Models;

namespace WeatherMVC.Controllers
{
    public class HomeController : Controller
    {
        ObservationsDBContext context = new ObservationsDBContext();
        public ActionResult Index()
        {
            //return View();
            List<RainObservation> rainobservations = context.RainObservations.ToList();
            return View(rainobservations);
        }



        public ActionResult Details(int id)
        {
            RainObservation rainobservation = context.RainObservations.SingleOrDefault(r => r.ObservationID == id);
            if (rainobservation == null)
            {
                return HttpNotFound();
            }
            return View(rainobservation);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RainObservation rainobservation)
        {
            if (ModelState.IsValid)
            {
                context.RainObservations.Add(rainobservation);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rainobservation);
        }


        public ActionResult Edit(int id)
        {
            RainObservation rainobservation = context.RainObservations.Single(r => r.ObservationID == id);
            if (rainobservation == null)
            {
                return HttpNotFound();
            }
            return View(rainobservation);
        }

        [HttpPost]
        public ActionResult Edit(int id, RainObservation rainobservation)
        {
            RainObservation _rainobservation = context.RainObservations.Single(r=> r.ObservationID == id);

            if (ModelState.IsValid)
            {
                _rainobservation.IncchesRain = rainobservation.IncchesRain;
                _rainobservation.WeatherStationID = rainobservation.WeatherStationID;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rainobservation);
        }


        public ActionResult Delete(int id)
        {
            RainObservation rainobservation = context.RainObservations.Single(r => r.ObservationID == id);
            if (rainobservation == null)
            {
                return HttpNotFound();
            }
            return View(rainobservation);
        }

        [HttpPost]
        public ActionResult Delete(int id, RainObservation rainobservation)
        {
            RainObservation _rainobservation = context.RainObservations.Single(r => r.ObservationID == id);
            context.RainObservations.Remove(_rainobservation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }






        public ActionResult About()
        {
            ViewBag.Message = "This page has weather observations.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Text or call me, I will get back to you!.";

            return View();
        }
    }
}