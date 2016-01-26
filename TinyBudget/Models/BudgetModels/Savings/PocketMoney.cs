using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class PocketMoney
    {
        [Key]
        public int pocketMoneyID { get; set; }
        public int pocketMoneyAmount { get; set; }
    }
}