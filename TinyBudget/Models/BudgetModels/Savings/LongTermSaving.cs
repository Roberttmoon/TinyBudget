using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class LongTermSaving
    {
        [Key]
        public int longTermSavingID { get; set; }
        public string longTermSavingName { get; set; }
        public int totalAmountToLongTermSave { get; set; }
        public int weeklyAmountToLongTermSave { get; set; }
        public DateTime dateAdded { get; set; }
        public string longTermSavingReason { get; set; }
    }
}