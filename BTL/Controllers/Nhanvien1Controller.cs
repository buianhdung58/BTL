using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL.Models;

namespace BTL.Controllers
{
    public class Nhanvien1Controller : Controller
    {
        private PTPMQLYDbContext db = new PTPMQLYDbContext();

        // GET: Nhanvien1
        public ActionResult Index()
        {
            return View(db.Nhanvien1.ToList());
        }

        // GET: Nhanvien1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien1 nhanvien1 = db.Nhanvien1.Find(id);
            if (nhanvien1 == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien1);
        }

        // GET: Nhanvien1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nhanvien1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CCCD,NhanvienID,Congty,FullName")] Nhanvien1 nhanvien1)
        {
            if (ModelState.IsValid)
            {
                db.Nhanvien1.Add(nhanvien1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanvien1);
        }

        // GET: Nhanvien1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien1 nhanvien1 = db.Nhanvien1.Find(id);
            if (nhanvien1 == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien1);
        }

        // POST: Nhanvien1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CCCD,NhanvienID,Congty,FullName")] Nhanvien1 nhanvien1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvien1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanvien1);
        }

        // GET: Nhanvien1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhanvien1 nhanvien1 = db.Nhanvien1.Find(id);
            if (nhanvien1 == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien1);
        }

        // POST: Nhanvien1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nhanvien1 nhanvien1 = db.Nhanvien1.Find(id);
            db.Nhanvien1.Remove(nhanvien1);
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
