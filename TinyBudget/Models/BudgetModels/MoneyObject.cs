using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TinyBudget.Models
{
    public class MoneyObject : IManipulateFunds
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public DateTime timeAdded { get; set; }

        public void MoveFunds(int moniesToMove, MoneyObject moneyWithdraw, MoneyObject moneyDeposit)
        {
            moneyWithdraw.amount -= moniesToMove;
            moneyDeposit.amount += moniesToMove;
        }
    }
}