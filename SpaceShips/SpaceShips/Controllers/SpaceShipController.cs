using SpaceShips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SpaceShips.Controllers
{
    public class SpaceShipController : Controller
    {
        // GET: SpaceShip
        private SpaceShipDBContext db = new SpaceShipDBContext();

        // Get: SpaceShips
        public ActionResult Index()
        {
            return View(db.SpaceShips.ToList());
        }

        //Get: SpaceShip/Create
        public ActionResult Create()
        {
            return View();
        }

        //Post: SpaceShip/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RestaurantID,Name,Location,Class")] SpaceShip spaceShip)
        {
            if (ModelState.IsValid)
            {
                db.SpaceShips.Add(spaceShip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spaceShip);
        }

        //Get:SpaceShip/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceShip spaceShip = db.SpaceShips.Find(id);
            if (spaceShip == null)
            {
                return HttpNotFound();
            }
            return View(spaceShip);
        }

        //Post: SpaceShips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SpaceShip spaceShip = db.SpaceShips.Find(id);
            db.SpaceShips.Remove(spaceShip);
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

        // Get: Restaurant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceShip spaceShip = db.SpaceShips.Find(id);
            if (spaceShip == null)
            {
                return HttpNotFound();
            }
            return View(spaceShip);
        }

        //Post: SpaceShips/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpaceShipID,Name,Location,Class")] SpaceShip spaceShip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spaceShip).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spaceShip);
        }

        //Get: SpaceShip/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpaceShip spaceShip = db.SpaceShips.Find(id);
            if (spaceShip == null)
            {
                return HttpNotFound();
            }
            return View(spaceShip);
        }
    }
}