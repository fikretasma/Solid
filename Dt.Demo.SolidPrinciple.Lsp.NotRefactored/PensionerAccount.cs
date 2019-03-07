using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.NotRefactored
{
    public class PensionerAccount : BankAccount
    {
        public override bool Withdraw(decimal amount)
        {
            decimal moneyAfterWithdrawal = Balance - amount;
            //update balance
            return (moneyAfterWithdrawal >= 0);
               
        }
    }
}
