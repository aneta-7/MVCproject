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
    public class PrzelotController : Controller
    {
        private SamolotDBContext db = new SamolotDBContext();

        // GET: Przelot
        public ActionResult Index()
        {
            return View(db.Przelots.ToList());
        }

        // GET: Przelot/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przelots.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // GET: Przelot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Przelot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PunktStartowty,Data1,Czas1,PunktKoncowy,Data2,Czas2,Samolot_id")] Przelot przelot)
        {
            if (ModelState.IsValid)
            {
                db.Przelots.Add(przelot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(przelot);
        }

        // GET: Przelot/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przelots.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // POST: Przelot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PunktStartowty,Data1,Czas1,PunktKoncowy,Data2,Czas2,Samolot_id")] Przelot przelot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przelot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(przelot);
        }

        // GET: Przelot/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Przelot przelot = db.Przelots.Find(id);
            if (przelot == null)
            {
                return HttpNotFound();
            }
            return View(przelot);
        }

        // POST: Przelot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Przelot przelot = db.Przelots.Find(id);
            db.Przelots.Remove(przelot);
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
