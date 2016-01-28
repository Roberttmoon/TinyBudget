using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyBudget.Models
{
    public interface IManipulateFunds
    {
        void MoveFunds(int moniesToMove, MoneyObject moneyWithdrawLocaton, MoneyObject moneyDeposit);
    }
}
