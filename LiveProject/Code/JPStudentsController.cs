using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JPDash.Models;
using System.Text.RegularExpressions;
using System.Text;
//using PagedList;

namespace JPDash.Controllers
{
    public class JPStudentsController : Controller
    {
        private JPDashTableContext db = new JPDashTableContext();

        // GET: JPStudents
        //  public ActionResult Index()

        //public ActionResult Index(string sortOrder)
        public ViewResult Index(string sortOrder,string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.LocationSortParm = sortOrder == "Location" ? "location_desc" : "Location";

            var students = from s in db.JPStudents
                           select s;

            if (!String.IsNullOrEmpty(searchString))
              {
                string searchStringNoSpaces = Regex.Replace(searchString, @"\s+", "");
                students = students.Where(s => s.JPStudentLocation.ToString().Contains(searchString) || s.JPStudentLocation.ToString().Contains(searchStringNoSpaces) || s.JPName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.JPName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.JPStartDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.JPStartDate);
                    break;
                case "Location":
                    students = students.OrderBy(s => s.JPStudentLocation);
                    break;
                case "location_desc":
                    students = students.OrderByDescending(s => s.JPStudentLocation);
                    break;
                default: //Name ascending
                    students = students.OrderBy(s => s.JPName);
                    break;
            }
            return View(students.ToList());


        }

      /* private ViewResult View(object p)
        {
            throw new NotImplementedException();
        }*/

        // GET: JPStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JPStudent jPStudent = db.JPStudents.Find(id);
            if (jPStudent == null)
            {
                return HttpNotFound();
            }
            return View(jPStudent);
        }

        // GET: JPStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JPStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JPStudentId,JPName,JPEmail,JPStudentLocation,JPStartDate,JPLinkedIn,JPPortfolio,JPContact")] JPStudent jPStudent)
        {
            if (ModelState.IsValid)
            {
                // Test to see if URL provided has http or https in it. If not, then save as is. If it does, strip the protocol.
                string linkedInUrl = jPStudent.JPLinkedIn;
                Regex regexLI = new Regex(@"^http(s)?://");
                Match matchLI = regexLI.Match(linkedInUrl);
                if (matchLI.Success)
                {
                    Uri linkedInNewURL = new Uri(linkedInUrl);
                    string linkedInOutput = linkedInNewURL.Host + linkedInNewURL.PathAndQuery;
                    jPStudent.JPLinkedIn = linkedInOutput;
                }
                else
                {
                    jPStudent.JPLinkedIn = linkedInUrl;
                }

                // Test to see if URL provided has http or https in it. If not, then save as is. If it does, strip the protocol.
                string portfolioUrl = jPStudent.JPPortfolio;
                Regex regexP = new Regex(@"^http(s)?://");
                Match matchP = regexP.Match(portfolioUrl);
                if (matchP.Success)
                {
                    Uri portfolioNewURL = new Uri(portfolioUrl);
                    string portfolioOutput = portfolioNewURL.Host + portfolioNewURL.PathAndQuery;
                    jPStudent.JPPortfolio = portfolioOutput;
                }
                else
                {
                    jPStudent.JPPortfolio = portfolioUrl;
                }

                jPStudent.JPStartDate = DateTime.Now;
                jPStudent.JPGraduated = false;
                db.JPStudents.Add(jPStudent);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(jPStudent);
        }

        // GET: JPStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JPStudent jPStudent = db.JPStudents.Find(id);
            if (jPStudent == null)
            {
                return HttpNotFound();
            }
            return View(jPStudent);
        }

        // POST: JPStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JPStudentId,JPName,JPEmail,JPStudentLocation,JPStartDate,JPLinkedIn,JPPortfolio,JPContact")] JPStudent jPStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jPStudent).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jPStudent);
        }

        // GET: JPStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JPStudent jPStudent = db.JPStudents.Find(id);
            if (jPStudent == null)
            {
                return HttpNotFound();
            }
            return View(jPStudent);
        }

        // POST: JPStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JPStudent jPStudent = db.JPStudents.Find(id);
            db.JPStudents.Remove(jPStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Result()
        {
            var emails = db.JPStudents.Select(x => x.JPEmail).ToList();
            string csv = string.Empty;
            foreach (var email in emails)
            {
                csv += email;
                csv += "\r\n";
            }

            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "StudentEmails.csv");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
