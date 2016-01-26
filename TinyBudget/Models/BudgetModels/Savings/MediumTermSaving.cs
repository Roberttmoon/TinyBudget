using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class MediumTermSaving
    {
        [Key]
        public int mediumTermSavingID { get; set; }
        public string mediumTermSaving { get; set; }
        public int totalAmountToMediumTermSave { get; set; }
        public int weeklyAmountToMediumTermSaving { get; set; }
        public DateTime dateStartedmediumTermSaving { get; set; }
    }
}