using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TinyBudget.Models
{
    public class BudgetModel
    {
        [Key]
        public int id;


    }

    public class BudgetDBConext
    {
        public DbSet<BudgetModel> BudgetModel { get; set; }
    }
}