using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.Refactored
{
    public class ChildAccount : BankAccountWithoutWithdraw
    {
        decimal taxAmount;
        public override decimal GetCurrentBalanceWithoutTax()
        {
            return Balance - taxAmount;
        }
    }
}
