using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class RequiredExp
    {
        [Key]
        public int requiredExpID { get; set; }
        public string requiredExpName { get; set; }
        public int requiredExpAmount { get; set; }
        public bool requiredExpReoccuring { get; set; }
        public int requiredExpReoccurNumDays { get; set; }
        public DateTime requiredExpDate { get; set; }
    }
}