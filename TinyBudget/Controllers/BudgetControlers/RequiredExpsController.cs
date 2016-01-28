using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TinyBudget.DataAccessLayer;
using TinyBudget.Models;

namespace TinyBudget.Controllers
{
    public class RequiredExpsController : Controller
    {
        private TinyBudgetContext db = new TinyBudgetContext();

        // GET: RequiredExps
        public async Task<ActionResult> Index()
        {
            return View(await db.RequiredExp.ToListAsync());
        }

        // GET: RequiredExps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequiredExp requiredExp = await db.RequiredExp.FindAsync(id);
            if (requiredExp == null)
            {
                return HttpNotFound();
            }
            return View(requiredExp);
        }

        // GET: RequiredExps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequiredExps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,reoccuring,daysTillReoccurance,name,amount,timeAdded")] RequiredExp requiredExp)
        {
            if (ModelState.IsValid)
            {
                db.RequiredExp.Add(requiredExp);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(requiredExp);
        }

        // GET: RequiredExps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequiredExp requiredExp = await db.RequiredExp.FindAsync(id);
            if (requiredExp == null)
            {
                return HttpNotFound();
            }
            return View(requiredExp);
        }

        // POST: RequiredExps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,reoccuring,daysTillReoccurance,name,amount,timeAdded")] RequiredExp requiredExp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requiredExp).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(requiredExp);
        }

        // GET: RequiredExps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequiredExp requiredExp = await db.RequiredExp.FindAsync(id);
            if (requiredExp == null)
            {
                return HttpNotFound();
            }
            return View(requiredExp);
        }

        // POST: RequiredExps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RequiredExp requiredExp = await db.RequiredExp.FindAsync(id);
            db.RequiredExp.Remove(requiredExp);
            await db.SaveChangesAsync();
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
