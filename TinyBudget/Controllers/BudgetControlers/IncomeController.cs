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
    public class IncomeController : Controller
    {
        private TinyBudgetContext db = new TinyBudgetContext();

        // GET: Income
        public async Task<ActionResult> Index()
        {
            return View(await db.IncomeModel.ToListAsync());
        }

        // GET: Income/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeModel incomeModel = await db.IncomeModel.FindAsync(id);
            if (incomeModel == null)
            {
                return HttpNotFound();
            }
            return View(incomeModel);
        }

        // GET: Income/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Income/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,reoccuring,daysTillReoccurance,name,amount,timeAdded")] IncomeModel incomeModel)
        {
            if (ModelState.IsValid)
            {
                PocketMoney pMoney = new PocketMoney();
                incomeModel.MoveFunds(incomeModel.amount, incomeModel, pMoney);
                db.PocketMoney.Add(pMoney);
                db.IncomeModel.Add(incomeModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(incomeModel);
        }

        // GET: Income/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeModel incomeModel = await db.IncomeModel.FindAsync(id);
            if (incomeModel == null)
            {
                return HttpNotFound();
            }
            return View(incomeModel);
        }

        // POST: Income/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,reoccuring,daysTillReoccurance,name,amount,timeAdded")] IncomeModel incomeModel)
        {
            if (ModelState.IsValid)
            {
                PocketMoney pMoney = new PocketMoney();
                incomeModel.MoveFunds(incomeModel.amount, incomeModel, pMoney);
                db.Entry(pMoney).State = EntityState.Modified;
                db.Entry(incomeModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(incomeModel);
        }

        // GET: Income/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeModel incomeModel = await db.IncomeModel.FindAsync(id);
            if (incomeModel == null)
            {
                return HttpNotFound();
            }
            return View(incomeModel);
        }

        // POST: Income/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IncomeModel incomeModel = await db.IncomeModel.FindAsync(id);
            db.IncomeModel.Remove(incomeModel);
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
