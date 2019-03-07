using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.DependecyInversionPrinciple.Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotifyCustomerService();
            var order = new OrderService(notificationService);
            var cart = new Cart();
            var payment = new Payment { Amount = 15 };
            order.Checkout(cart, payment);
        }
    }
}
