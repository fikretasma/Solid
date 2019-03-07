using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.DependecyInversionPrinciple.Refactored
{
    public interface INotifyCustomerService
    {
        void NotifyCustomer(Cart cart);
    }
}
