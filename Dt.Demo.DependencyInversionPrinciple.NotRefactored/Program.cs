using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.DependencyInversionPrinciple.NotRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderService();
            var cart = new Cart();
            var payment = new Payment { Amount = 15 };
            order.Checkout(cart, payment);
        }
    }
}
