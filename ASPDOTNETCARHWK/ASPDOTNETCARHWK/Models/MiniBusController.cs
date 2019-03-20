using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPDOTNETCARHWK;

namespace ASPDOTNETCARHWK.Models
{
    public class MiniBusController : Controller
    {
        private RentACar db = new RentACar();

        // GET: MiniBus
        public ActionResult Index()
        {
            return View(db.MiniBus.ToList());
        }

        // GET: MiniBus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniBus miniBus = db.MiniBus.Find(id);
            if (miniBus == null)
            {
                return HttpNotFound();
            }
            return View(miniBus);
        }

        // GET: MiniBus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MiniBus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MinibusID,regNumber,MiniBusColour,miniBusManufacturer,numberOfSeats,miniBusSize")] MiniBus miniBus)
        {
            if (ModelState.IsValid)
            {
                db.MiniBus.Add(miniBus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(miniBus);
        }

        // GET: MiniBus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniBus miniBus = db.MiniBus.Find(id);
            if (miniBus == null)
            {
                return HttpNotFound();
            }
            return View(miniBus);
        }

        // POST: MiniBus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MinibusID,regNumber,MiniBusColour,miniBusManufacturer,numberOfSeats,miniBusSize")] MiniBus miniBus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miniBus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(miniBus);
        }

        // GET: MiniBus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniBus miniBus = db.MiniBus.Find(id);
            if (miniBus == null)
            {
                return HttpNotFound();
            }
            return View(miniBus);
        }

        // POST: MiniBus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MiniBus miniBus = db.MiniBus.Find(id);
            db.MiniBus.Remove(miniBus);
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
