using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class PocketMoney : MoneyObject
    {
        [Key]
        public int id = 1;
        [NotMapped]
        public string name { get; set; }
        [NotMapped]
        public DateTime timeAdded { get; set; }
    }
}