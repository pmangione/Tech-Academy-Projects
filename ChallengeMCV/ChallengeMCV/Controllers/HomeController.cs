using ChallengeMCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChallengeMCV.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comicBooks = ComicBookManager.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Details(int id)
        {
            var comicBooks = ComicBookManager.GetComicBooks();
            var myComicBook = comicBooks.Where(x => x.ComicBookId == id).FirstOrDefault();
            return View(myComicBook);
        }
    }
}