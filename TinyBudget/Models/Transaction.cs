using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class Transaction : MoneyObject
    {
        public bool reoccuring { get; set; }
        public int daysTillReoccurance { get; set; }
    }
}