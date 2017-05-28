using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GP_EmergencyBackend.Models;

namespace GP_EmergencyBackend.Controllers
{
    public class AmbulanceController : Controller
    {
        private TrafficEntities db = new TrafficEntities();

        //
        // GET: /Ambulance/

        public ActionResult Index()
        {
            return View(db.real_accident.ToList());
        }
        public ActionResult whole_map()
        {   
            ViewBag.Latitude = db.real_accident.Select(a => a.latitude).First();

            ViewBag.Longitude = db.real_accident.Select(a => a.longitude).First();

            return View("Location", db.real_accident.ToList());
        }
        //
        // GET: /Ambulance/Details/5

        public ActionResult Details(int id = 0)
        {
            real_accident real_accident = db.real_accident.Find(id);
            if (real_accident == null)
            {
                return HttpNotFound();
            }
            return View(real_accident);
        }

        //
        // GET: /Ambulance/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ambulance/Create

        [HttpPost]
        public ActionResult Create(real_accident real_accident)
        {
            if (ModelState.IsValid)
            {
                db.real_accident.Add(real_accident);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(real_accident);
        }

        //
        // GET: /Ambulance/Edit/5

        public ActionResult Edit(int id = 0)
        {
            real_accident real_accident = db.real_accident.Find(id);
            if (real_accident == null)
            {
                return HttpNotFound();
            }
            return View(real_accident);
        }

        //
        // POST: /Ambulance/Edit/5

        [HttpPost]
        public ActionResult Edit(real_accident real_accident)
        {
            if (ModelState.IsValid)
            {
                db.Entry(real_accident).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(real_accident);
        }

        //
        // GET: /Ambulance/Delete/5

        public ActionResult Delete(int id = 0)
        {
            real_accident real_accident = db.real_accident.Find(id);
            if (real_accident == null)
            {
                return HttpNotFound();
            }
            return View(real_accident);
        }

        //
        // POST: /Ambulance/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            real_accident real_accident = db.real_accident.Find(id);
            db.real_accident.Remove(real_accident);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}