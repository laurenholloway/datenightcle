using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DateNightCleveland.Models;

namespace DateNightCleveland.Controllers
{
    public class DatesModelsController : Controller
    {
        private DateNightClevelandContext db = new DateNightClevelandContext();

        // GET: DatesModels
        public ActionResult Index()
        {
            return View(db.DatesModels.ToList());
        }

        // GET: DatesModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatesModel datesModel = db.DatesModels.Find(id);
            if (datesModel == null)
            {
                return HttpNotFound();
            }
            return View(datesModel);
        }

        // GET: DatesModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DateID,Title,Description,Image,TimeOfDay,Price,Website,Phone,DateType")] DatesModel datesModel)
        {
            if (ModelState.IsValid)
            {
                db.DatesModels.Add(datesModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datesModel);
        }

        // GET: DatesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatesModel datesModel = db.DatesModels.Find(id);
            if (datesModel == null)
            {
                return HttpNotFound();
            }
            return View(datesModel);
        }

        // POST: DatesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DateID,Title,Description,Image,TimeOfDay,Price,Website,Phone,DateType")] DatesModel datesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datesModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datesModel);
        }

        // GET: DatesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatesModel datesModel = db.DatesModels.Find(id);
            if (datesModel == null)
            {
                return HttpNotFound();
            }
            return View(datesModel);
        }

        // POST: DatesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatesModel datesModel = db.DatesModels.Find(id);
            db.DatesModels.Remove(datesModel);
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
