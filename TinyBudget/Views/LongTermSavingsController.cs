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

namespace TinyBudget.Views
{
    public class LongTermSavingsController : Controller
    {
        private TinyBudgetContext db = new TinyBudgetContext();

        // GET: LongTermSavings
        public async Task<ActionResult> Index()
        {
            return View(await db.LongTermSaving.ToListAsync());
        }

        // GET: LongTermSavings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LongTermSaving longTermSaving = await db.LongTermSaving.FindAsync(id);
            if (longTermSaving == null)
            {
                return HttpNotFound();
            }
            return View(longTermSaving);
        }

        // GET: LongTermSavings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LongTermSavings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,WeelkyAmount,ReasonToSave,name,amount,timeAdded")] LongTermSaving longTermSaving)
        {
            if (ModelState.IsValid)
            {
                db.LongTermSaving.Add(longTermSaving);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(longTermSaving);
        }

        // GET: LongTermSavings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LongTermSaving longTermSaving = await db.LongTermSaving.FindAsync(id);
            if (longTermSaving == null)
            {
                return HttpNotFound();
            }
            return View(longTermSaving);
        }

        // POST: LongTermSavings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,WeelkyAmount,ReasonToSave,name,amount,timeAdded")] LongTermSaving longTermSaving)
        {
            if (ModelState.IsValid)
            {
                db.Entry(longTermSaving).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(longTermSaving);
        }

        // GET: LongTermSavings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LongTermSaving longTermSaving = await db.LongTermSaving.FindAsync(id);
            if (longTermSaving == null)
            {
                return HttpNotFound();
            }
            return View(longTermSaving);
        }

        // POST: LongTermSavings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            LongTermSaving longTermSaving = await db.LongTermSaving.FindAsync(id);
            db.LongTermSaving.Remove(longTermSaving);
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
