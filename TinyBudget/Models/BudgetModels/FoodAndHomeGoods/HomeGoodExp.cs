using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class HomeGoodExp
    {
        [Key]
        public int homeGoodExpID { get; set; }
        public string homeGoodExpName { get; set; }
        public bool homeGoodExpReoccuring { get; set; }
        public int homeGoodExpReoccurNumDays { get; set; }
        public DateTime homeGoodExpDate { get; set; }
    }
}