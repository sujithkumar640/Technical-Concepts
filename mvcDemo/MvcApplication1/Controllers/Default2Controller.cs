using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class Default2Controller : Controller
    {
        private cdkEntities db = new cdkEntities();

        //
        // GET: /Default2/

        public ActionResult Index()
        {
            return View(db.cdk_users.ToList());
        }

        //
        // GET: /Default2/Details/5

        public ActionResult Details(int id = 0)
        {
            cdk_users cdk_users = db.cdk_users.Find(id);
            if (cdk_users == null)
            {
                return HttpNotFound();
            }
            return View(cdk_users);
        }

        //
        // GET: /Default2/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default2/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(cdk_users cdk_users)
        {
            if (ModelState.IsValid)
            {
                db.cdk_users.Add(cdk_users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cdk_users);
        }

        //
        // GET: /Default2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            cdk_users cdk_users = db.cdk_users.Find(id);
            if (cdk_users == null)
            {
                return HttpNotFound();
            }
            return View(cdk_users);
        }

        //
        // POST: /Default2/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(cdk_users cdk_users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cdk_users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cdk_users);
        }

        //
        // GET: /Default2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            cdk_users cdk_users = db.cdk_users.Find(id);
            if (cdk_users == null)
            {
                return HttpNotFound();
            }
            return View(cdk_users);
        }

        //
        // POST: /Default2/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cdk_users cdk_users = db.cdk_users.Find(id);
            db.cdk_users.Remove(cdk_users);
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