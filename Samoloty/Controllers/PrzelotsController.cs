using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Samoloty.Models;

namespace Samoloty.Controllers
{
    public class PrzelotsController : Controller
    {
        private PrzelotDBContext db = new PrzelotDBContext();

        // GET: Przelots
        public ActionResult Index()
        {
            return View(db.Przeloty.ToList());
        }

        // GET: Przelots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przeloty.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // GET: Przelots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Przelots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PunktStartowty,Data1,Czas1,PunktKoncowy,Data2,Czas2")] Przelot przelot)
        {
            if (ModelState.IsValid)
            {
                db.Przeloty.Add(przelot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(przelot);
        }

        // GET: Przelots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przeloty.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // POST: Przelots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PunktStartowty,Data1,Czas1,PunktKoncowy,Data2,Czas2")] Przelot przelot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przelot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(przelot);
        }

        // GET: Przelots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przeloty.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // POST: Przelots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Przelot przelot = db.Przeloty.Find(id);
            db.Przeloty.Remove(przelot);
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
