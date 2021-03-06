using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class ItemStockModelsController : Controller
    {
        private ItemStockContext db = new ItemStockContext();

        // GET: ItemStockModels
        public ActionResult Index()
        {
            return View(db.StockModel.ToList());
        }

        // GET: ItemStockModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemStockModels itemStockModels = db.StockModel.Find(id);
            if (itemStockModels == null)
            {
                return HttpNotFound();
            }
            return View(itemStockModels);
        }

        // GET: ItemStockModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemStockModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Category,Price")] ItemStockModels itemStockModels)
        {
            if (ModelState.IsValid)
            {
                db.StockModel.Add(itemStockModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemStockModels);
        }

        // GET: ItemStockModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemStockModels itemStockModels = db.StockModel.Find(id);
            if (itemStockModels == null)
            {
                return HttpNotFound();
            }
            return View(itemStockModels);
        }

        // POST: ItemStockModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Category,Price")] ItemStockModels itemStockModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemStockModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemStockModels);
        }

        // GET: ItemStockModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemStockModels itemStockModels = db.StockModel.Find(id);
            if (itemStockModels == null)
            {
                return HttpNotFound();
            }
            return View(itemStockModels);
        }

        // POST: ItemStockModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemStockModels itemStockModels = db.StockModel.Find(id);
            db.StockModel.Remove(itemStockModels);
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
