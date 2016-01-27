using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class MoneyObject
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public DateTime timeAdded { get; set; }
    }
}