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
    public class tabunganController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: tabungan
        public ActionResult Index()
        {
            return View(db.tabunganObject.ToList());
        }

        // GET: tabungan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabungan tabungan = db.tabunganObject.Find(id);
            if (tabungan == null)
            {
                return HttpNotFound();
            }
            return View(tabungan);
        }

        // GET: tabungan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tabungan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tabungan,tanggal_mulai,tanggal_berakhir,id_user")] tabungan tabungan)
        {
            if (ModelState.IsValid)
            {
                db.tabunganObject.Add(tabungan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabungan);
        }

        // GET: tabungan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabungan tabungan = db.tabunganObject.Find(id);
            if (tabungan == null)
            {
                return HttpNotFound();
            }
            return View(tabungan);
        }

        // POST: tabungan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tabungan,tanggal_mulai,tanggal_berakhir,id_user")] tabungan tabungan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabungan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabungan);
        }

        // GET: tabungan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabungan tabungan = db.tabunganObject.Find(id);
            if (tabungan == null)
            {
                return HttpNotFound();
            }
            return View(tabungan);
        }

        // POST: tabungan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tabungan tabungan = db.tabunganObject.Find(id);
            db.tabunganObject.Remove(tabungan);
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
