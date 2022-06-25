using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tabungan_project.DataContext;
using tabungan_project.Models;

namespace tabungan_project.Controllers
{
    public class detail_tabunganController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: detail_tabungan
        public ActionResult Index()
        {
            return View(db.detail_tabunganObject.ToList());
        }

        // GET: detail_tabungan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detail_tabungan detail_tabungan = db.detail_tabunganObject.Find(id);
            if (detail_tabungan == null)
            {
                return HttpNotFound();
            }
            return View(detail_tabungan);
        }

        // GET: detail_tabungan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: detail_tabungan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nomor_seri,quantity,id_tabungan,id_item")] detail_tabungan detail_tabungan)
        {
            if (ModelState.IsValid)
            {
                db.detail_tabunganObject.Add(detail_tabungan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detail_tabungan);
        }

        // GET: detail_tabungan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detail_tabungan detail_tabungan = db.detail_tabunganObject.Find(id);
            if (detail_tabungan == null)
            {
                return HttpNotFound();
            }
            return View(detail_tabungan);
        }

        // POST: detail_tabungan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nomor_seri,quantity,id_tabungan,id_item")] detail_tabungan detail_tabungan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detail_tabungan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detail_tabungan);
        }

        // GET: detail_tabungan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            detail_tabungan detail_tabungan = db.detail_tabunganObject.Find(id);
            if (detail_tabungan == null)
            {
                return HttpNotFound();
            }
            return View(detail_tabungan);
        }

        // POST: detail_tabungan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            detail_tabungan detail_tabungan = db.detail_tabunganObject.Find(id);
            db.detail_tabunganObject.Remove(detail_tabungan);
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
