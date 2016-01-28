using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class Savings : MoneyObject
    {
        public int WeelkyAmount { get; set; }
        public string ReasonToSave { get; set; }
    }
}