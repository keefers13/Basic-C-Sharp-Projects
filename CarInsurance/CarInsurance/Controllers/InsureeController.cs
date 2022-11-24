using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

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
                //converting the insuree.Quote to type 'double' 
                double quote = Convert.ToDouble(insuree.Quote);
                quote = 50;//sets the base price for the quote at 50
                DateTime year = DateTime.Now;
                DateTime birthday = insuree.DateOfBirth;


                //calculates age of the user
                int bDayMonth = year.Month - birthday.Month;
                int bDayday = year.Day - birthday.Day;
                int age = year.Year - birthday.Year;
                if (bDayMonth <= 0 && bDayday <= 0) age--;//handles when the birthday has not yet happened this year

                if (age <= 18)
                {
                    quote += 100;
                }
                else if (age <= 25 && age >= 19)
                {
                    quote += 50;
                }
                else
                {
                    quote += 25;
                }

                //Car's year Calculation 
                int carYear = insuree.CarYear;
                if (carYear < 2000 || carYear > 2015)
                {
                    quote += 25;
                }

                //Car's Make/Model Calculation
                string carMake = insuree.CarMake.ToLower();
                string carModel = insuree.CarModel.ToLower();
                if (carMake == "porsche" && carModel == "911 carrera")
                {
                    quote += 50;
                }
                else if (carMake == "porsche")
                {
                    quote += 25;
                }

                //Speeding ticket Calculation
                int tickets = insuree.SpeedingTickets;
                quote = quote + tickets * 10;

                //dui/dwi Calculations
                bool hasDUI = insuree.DUI;
                double duiUpCharge = 0;
                if (hasDUI)
                {
                    duiUpCharge = quote * .25;

                }
                quote += duiUpCharge;

                //Coverage Calculations
                bool isFullCoverage = insuree.CoverageType;
                double coverageUpCharge = 0;
                if (isFullCoverage)
                {
                    coverageUpCharge = quote * .5;
                    //quote = quote * 1.5;
                }
                quote += coverageUpCharge;

                //sets the quote attribute to the quote that was just calculated
                insuree.Quote = Convert.ToDecimal(quote);

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

        public ActionResult Admin()
        {
            //view model
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<insureeVM>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new insureeVM();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
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
