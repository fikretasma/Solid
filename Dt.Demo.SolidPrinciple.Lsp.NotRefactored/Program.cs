using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciple.Lsp.NotRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountManager pensionerAccountManager = new AccountManager(new PensionerAccount());
            pensionerAccountManager.Withdraw(15);

            AccountManager adultAccountManager = new AccountManager(new AdultAccount());
            adultAccountManager.Withdraw(10);


            AccountManager childAccountManager = new AccountManager(new ChildAccount());
            childAccountManager.Withdraw(10);
        }
    }
}
