using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDisplayTemplates.Models;

namespace MvcDisplayTemplates.Controllers
{
    public class DefaultController : Controller
    {
        private TimeCardContext db = new TimeCardContext();

        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View(db.TimeCards.ToList());
        }

        //
        // GET: /Default/Details/5

        public ActionResult Details(int id = 0)
        {
            TimeCard timecard = db.TimeCards.Find(id);
            if (timecard == null)
            {
                return HttpNotFound();
            }
            return View(timecard);
        }

        //
        // GET: /Default/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TimeCard timecard)
        {
            if (ModelState.IsValid)
            {
                db.TimeCards.Add(timecard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timecard);
        }

        //
        // GET: /Default/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TimeCard timecard = db.TimeCards.Find(id);
            if (timecard == null)
            {
                return HttpNotFound();
            }
            return View(timecard);
        }

        //
        // POST: /Default/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TimeCard timecard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timecard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timecard);
        }

        //
        // GET: /Default/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TimeCard timecard = db.TimeCards.Find(id);
            if (timecard == null)
            {
                return HttpNotFound();
            }
            return View(timecard);
        }

        //
        // POST: /Default/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeCard timecard = db.TimeCards.Find(id);
            db.TimeCards.Remove(timecard);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}