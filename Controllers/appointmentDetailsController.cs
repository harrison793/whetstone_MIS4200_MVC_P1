using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using whetstone_MIS4200_MVC_P1.DAL1;
using whetstone_MIS4200_MVC_P1.Models;

namespace whetstone_MIS4200_MVC_P1.Controllers
{
    public class appointmentDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: appointmentDetails
        public ActionResult Index()
        {
            return View(db.AppointmentDetails.ToList());
        }

        // GET: appointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: appointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentDetailID,unitCost,price,procedureID,productID")] appointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentDetails.Add(appointmentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // POST: appointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentDetailID,unitCost,price,procedureID,productID")] appointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // POST: appointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            appointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            db.AppointmentDetails.Remove(appointmentDetail);
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
