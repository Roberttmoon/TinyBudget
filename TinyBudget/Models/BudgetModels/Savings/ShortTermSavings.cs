using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class ShortTermSavings
    {
        [Key]
        public int shortTermSavingsID { get; set; }
        public string shortTermSavingsName { get; set; }
        public int totalAmountToShortTermSaving { get; set; }
        public int weeklyAmountToShortTermSavings { get; set; }
        public DateTime shortTermSavingsStartDate { get; set; }
    }
}