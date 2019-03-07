using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.NotRefactored
{
    public abstract class BankAccount
    {
        public decimal Balance { get; set; }
        public abstract bool Withdraw(decimal amount);
    }
}
