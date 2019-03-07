using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.NotRefactored
{
    public class AccountManager
    {
        private BankAccount _bankAccount;
        public AccountManager(BankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public void Withdraw(decimal amount) {
            _bankAccount.Withdraw(amount);
        }
    }
}
