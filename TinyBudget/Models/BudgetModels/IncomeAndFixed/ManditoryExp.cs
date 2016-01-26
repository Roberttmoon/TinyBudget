using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class ManditoryExp
    {
        [Key]
        public int manditoryExpID { get; set; }
        public string manditoryExpName { get; set; }
        public int manditoryExpAmount { get; set; }
        public bool manditoryExpReoccurring { get; set; }
        public int manditoryExpReoccurEveryNumDays { get; set; }
        public DateTime manditoryExpDate { get; set; }
    }
}