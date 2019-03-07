using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.Refactored
{
    public abstract class BankAccountWithoutWithdraw:BankAccount
    {
        public abstract decimal GetCurrentBalanceWithoutTax();
    }
}
