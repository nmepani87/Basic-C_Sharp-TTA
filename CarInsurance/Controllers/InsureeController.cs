using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
                {
                // Set base value
                insuree.Quote = 50;
                // Age working out
                DateTime dateTime = DateTime.Now;
                TimeSpan numofyears = dateTime.Subtract(insuree.DateOfBirth);
                int ageindays = numofyears.Days;
                int age = ageindays / 365;
                // Age check to see how much to add to base total
                if (age <= 18)
                {
                    insuree.Quote += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    insuree.Quote += 50;
                }
                else
                {
                    insuree.Quote += 25;
                }

                // car year check to see what to add to base
                if (insuree.CarYear <= 2000 || insuree.CarYear >= 2015)
                {
                    insuree.Quote += 25;
                }

                // car make check, and if specific model too

                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                    if (insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote += 25;
                    }
                }

                // add amount to total depending on num of speeding tickets
                if (insuree.SpeedingTickets != 0)
                {
                    insuree.Quote += (insuree.SpeedingTickets * 10);
                }

                // add % to total depending on DUI 
                if (insuree.DUI == true)
                {
                    insuree.Quote += (insuree.Quote / 4);
                }

                // if full coverage wanted add a certain % of total to totalB
                if (insuree.CoverageType == true)
                {
                    insuree.Quote += (insuree.Quote / 2);
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insureeList = (from x in db.Insurees where x.Id > 0 select x).ToList();
                var displayList = new List<Insuree>();

                foreach (var insuree in insureeList)
                {
                    var selectCol = new Insuree();
                    selectCol.FirstName = insuree.FirstName;
                    selectCol.LastName = insuree.LastName;
                    selectCol.EmailAddress = insuree.EmailAddress;
                    selectCol.Quote = insuree.Quote;
                    displayList.Add(selectCol);
                }
                return View(displayList);
            }
        }
    }
}
