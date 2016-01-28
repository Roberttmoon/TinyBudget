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

namespace TinyBudget.Controlers
{
    public class BudgetController : Controller
    {
        private TinyBudgetContext db = new TinyBudgetContext();

        // GET: Budget
        public async Task<ActionResult> Index()
        {
            return View(await db.BudgetModels.ToListAsync());
        }

        // GET: Budget/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.BudgetModel budgetModel = await db.BudgetModels.FindAsync(id);
            if (budgetModel == null)
            {
                return HttpNotFound();
            }
            return View(budgetModel);
        }
    }
}
