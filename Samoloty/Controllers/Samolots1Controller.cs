﻿using System;
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
    public class Samolots1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Samolots1
        public ActionResult Index()
        {
            return View(db.Samolots.ToList());
        }

        // GET: Samolots1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samolot samolot = db.Samolots.Find(id);
            if (samolot == null)
            {
                return HttpNotFound();
            }
            return View(samolot);
        }

        // GET: Samolots1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Samolots1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nazwa,Typ")] Samolot samolot)
        {
            if (ModelState.IsValid)
            {
                db.Samolots.Add(samolot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(samolot);
        }

        // GET: Samolots1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samolot samolot = db.Samolots.Find(id);
            if (samolot == null)
            {
                return HttpNotFound();
            }
            return View(samolot);
        }

        // POST: Samolots1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa,Typ")] Samolot samolot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(samolot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(samolot);
        }

        // GET: Samolots1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samolot samolot = db.Samolots.Find(id);
            if (samolot == null)
            {
                return HttpNotFound();
            }
            return View(samolot);
        }

        // POST: Samolots1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Samolot samolot = db.Samolots.Find(id);
            db.Samolots.Remove(samolot);
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
