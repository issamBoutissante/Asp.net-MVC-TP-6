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
    public class PilotesController : Controller
    {
        private Companie_VoyageEntities1 db = new Companie_VoyageEntities1();

        // GET: Pilotes
        public ActionResult Index()
        {
            return View(db.Pilotes.ToList());
        }

        // GET: Pilotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilote pilote = db.Pilotes.Find(id);
            if (pilote == null)
            {
                return HttpNotFound();
            }
            return View(pilote);
        }

        // GET: Pilotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pilotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumPil,NomPil,PrenomPil,Adresse,Salaire,Prime")] Pilote pilote)
        {
            if (ModelState.IsValid)
            {
                db.Pilotes.Add(pilote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pilote);
        }

        // GET: Pilotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilote pilote = db.Pilotes.Find(id);
            if (pilote == null)
            {
                return HttpNotFound();
            }
            return View(pilote);
        }

        // POST: Pilotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumPil,NomPil,PrenomPil,Adresse,Salaire,Prime")] Pilote pilote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pilote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pilote);
        }

        // GET: Pilotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pilote pilote = db.Pilotes.Find(id);
            if (pilote == null)
            {
                return HttpNotFound();
            }
            return View(pilote);
        }

        // POST: Pilotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pilote pilote = db.Pilotes.Find(id);
            db.Pilotes.Remove(pilote);
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
