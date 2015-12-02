using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using System.Net;
using PreviewCinemas.Models;

namespace PreviewCinemas.Controllers
{
    public class HomeController : Controller
    {
        private CinemaContext db = new CinemaContext();

        public ActionResult Index()
        {
            return View(db.Movies.ToList());
            
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