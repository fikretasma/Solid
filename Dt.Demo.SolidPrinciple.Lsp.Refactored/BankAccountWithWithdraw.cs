using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.Refactored
{
    public abstract class BankAccountWithWithdraw:BankAccount
    {
        public abstract bool Withdraw(decimal amount);
    }
}
