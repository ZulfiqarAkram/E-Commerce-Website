using IMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace IMS_Project.Controllers
{
    public class SupplierController : Controller
    {

        KahreedoEntities db = new KahreedoEntities();

        // GET: Supplier
        public ActionResult Index()
        {
            return View(db.Suppliers.ToList());
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Supplier supp)
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(supp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Supplier supp = db.Suppliers.Single(x => x.SupplierID == id);
            if (supp==null)
            {
                return HttpNotFound();
            }
            return View(supp);
        }

        [HttpPost]
        public ActionResult Edit(Supplier supp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supp);
        }

        public ActionResult Details(int id)
        {
            Supplier supp = db.Suppliers.Find(id);
            if (supp == null)
            {
                return HttpNotFound();
            }
            return View(supp);
        }

        public ActionResult Delete(int id)
        {
            Supplier supp = db.Suppliers.Find(id);
            if (supp == null)
            {
                return HttpNotFound();
            }
            return View(supp);
        }

        //Post Delete Confirmed
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Supplier supp = db.Suppliers.Find(id);
            db.Suppliers.Remove(supp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}