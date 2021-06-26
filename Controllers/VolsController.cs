using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Asp.net_MVC_TP_6.Models;

namespace Asp.net_MVC_TP_6.Controllers
{
    public class VolsController : Controller
    {
        private Companie_VoyageEntities1 db = new Companie_VoyageEntities1();

        // GET: Vols
        public ActionResult Index()
        {
            var vols = db.Vols.Include(v => v.Avion).Include(v => v.Pilote);
            return View(vols.ToList());
        }

        // GET: Vols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vol vol = db.Vols.Find(id);
            string s = vol.Pilote.NomPil.ToString();
            if (vol == null)
            {
                return HttpNotFound();
            }
            return View(vol);
        }

        // GET: Vols/Create
        public ActionResult Create()
        {
            ViewBag.NumAv = new SelectList(db.Avions, "NumAv", "NomAv");
            ViewBag.NumPil = new SelectList(db.Pilotes, "NumPil", "NomPil");
            return View();
        }

        // POST: Vols/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumVol,NumPil,NumAv,Date_Vol,Heure_dep,Heure_arr,Ville_dep,Ville_arr")] Vol vol)
        {
            if (ModelState.IsValid)
            {
                db.Vols.Add(vol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NumAv = new SelectList(db.Avions, "NumAv", "NomAv", vol.NumAv);
            ViewBag.NumPil = new SelectList(db.Pilotes, "NumPil", "NomPil", vol.NumPil);
            return View(vol);
        }

        // GET: Vols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vol vol = db.Vols.Find(id);
            if (vol == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumAv = new SelectList(db.Avions, "NumAv", "NomAv", vol.NumAv);
            ViewBag.NumPil = new SelectList(db.Pilotes, "NumPil", "NomPil", vol.NumPil);
            return View(vol);
        }

        // POST: Vols/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumVol,NumPil,NumAv,Date_Vol,Heure_dep,Heure_arr,Ville_dep,Ville_arr")] Vol vol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NumAv = new SelectList(db.Avions, "NumAv", "NomAv", vol.NumAv);
            ViewBag.NumPil = new SelectList(db.Pilotes, "NumPil", "NomPil", vol.NumPil);
            return View(vol);
        }

        // GET: Vols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vol vol = db.Vols.Find(id);
            if (vol == null)
            {
                return HttpNotFound();
            }
            return View(vol);
        }

        // POST: Vols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vol vol = db.Vols.Find(id);
            db.Vols.Remove(vol);
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
