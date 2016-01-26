using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class IncomeModel
    {
        [Key]
        public int incomeID { get; set; }
        public string incomeName { get; set; }
        public int incomeAmount { get; set; }
        public bool incomeReoccurring { get; set; }
        public int incomeReoccurEveryNumDays { get; set; }
        public DateTime incomeDate { get; set; }
    }
}