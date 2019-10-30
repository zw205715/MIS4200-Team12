using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200_Team12.DAL;
using MIS4200_Team12.Models;

namespace MIS4200_Team12.Controllers
{
    public class TheProfilesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: TheProfiles
        public ActionResult Index()
        {
            return View(db.TheProfiles.ToList());
        }

        // GET: TheProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheProfile theProfile = db.TheProfiles.Find(id);
            if (theProfile == null)
            {
                return HttpNotFound();
            }
            return View(theProfile);
        }

        // GET: TheProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "employeeID,firstName,lastName,email,phone,employeeSince")] TheProfile theProfile)
        {
            if (ModelState.IsValid)
            {
                db.TheProfiles.Add(theProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(theProfile);
        }

        // GET: TheProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheProfile theProfile = db.TheProfiles.Find(id);
            if (theProfile == null)
            {
                return HttpNotFound();
            }
            return View(theProfile);
        }

        // POST: TheProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "employeeID,firstName,lastName,email,phone,employeeSince")] TheProfile theProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theProfile);
        }

        // GET: TheProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TheProfile theProfile = db.TheProfiles.Find(id);
            if (theProfile == null)
            {
                return HttpNotFound();
            }
            return View(theProfile);
        }

        // POST: TheProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TheProfile theProfile = db.TheProfiles.Find(id);
            db.TheProfiles.Remove(theProfile);
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
