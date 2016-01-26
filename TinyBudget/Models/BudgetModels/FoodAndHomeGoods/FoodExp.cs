using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class FoodExp
    {
        [Key]
        public int foodExpID { get; set; }
        public string foodExpName { get; set; }
        public bool foodExpReoccuring { get; set; }
        public int foodExpReoccurNumDays { get; set; }
        public DateTime foodExpDate { get; set; }
    }
}