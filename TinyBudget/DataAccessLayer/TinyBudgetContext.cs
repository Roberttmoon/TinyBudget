using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TinyBudget.DataAccessLayer
{
    public class TinyBudgetContext : DbContext
    {
        public TinyBudgetContext() : base("TinyBudgetContext")
        {
        }
        public DbSet<Models.IncomeModel> IncomeModel { get; set; }
        public DbSet<Models.RequiredExp> RequiredExp { get; set; }
        public DbSet<Models.ManditoryExp> ManditoryExp { get; set; }
        public DbSet<Models.FoodExp> FoodExp { get; set; }
        public DbSet<Models.HomeGoodExp> HomeGoodExp { get; set; }
        public DbSet<Models.LongTermSaving> LongTermSaving { get; set; }
        public DbSet<Models.MediumTermSaving> MediumTermSaving { get; set; }
        public DbSet<Models.ShortTermSaving> ShortTermSaving { get; set; }
        public DbSet<Models.PocketMoney> PocketMoney { get; set; }

        public System.Data.Entity.DbSet<TinyBudget.Models.BudgetModel> BudgetModels { get; set; }
    }
}