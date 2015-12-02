using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PreviewCinemas.Models;

namespace PreviewCinemas.Controllers
{
    public class ShowingsController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: Showings
        public ActionResult Index()
        {
            var showings = db.Showings.Include(s => s.Movie).Include(s => s.Screen);
            return View(showings.ToList());
        }

        // GET: Showings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing showing = db.Showings.Find(id);
            if (showing == null)
            {
                return HttpNotFound();
            }

            return View(showing);
        }

        // GET: Showings/Create
        public ActionResult Create()
        {
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Title");
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID");
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        // POST: Showings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowingID,MovieID,ScreenID,DateAndTime,Price")] Showing showing)
        {
            if (ModelState.IsValid)
            {
                db.Showings.Add(showing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Title", showing.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", showing.ScreenID);
            return View(showing);
        }

        // GET: Showings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing showing = db.Showings.Find(id);
            if (showing == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Title", showing.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", showing.ScreenID);
            return View(showing);
        }

        // POST: Showings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowingID,MovieID,ScreenID,DateAndTime,Price")] Showing showing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Title", showing.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", showing.ScreenID);
            return View(showing);
        }

        // GET: Showings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing showing = db.Showings.Find(id);
            if (showing == null)
            {
                return HttpNotFound();
            }
            return View(showing);
        }

        // POST: Showings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Showing showing = db.Showings.Find(id);
            db.Showings.Remove(showing);
            db.SaveChanges();
            return RedirectToAction("Index");
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
