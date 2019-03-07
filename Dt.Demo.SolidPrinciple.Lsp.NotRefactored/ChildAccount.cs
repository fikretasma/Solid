using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.NotRefactored
{
    public class ChildAccount : BankAccount
    {
        public override bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
