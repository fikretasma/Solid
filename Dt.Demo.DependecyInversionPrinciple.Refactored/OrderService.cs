using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.DependecyInversionPrinciple.Refactored
{
    public class OrderService
    {
        private readonly INotifyCustomerService _notifyCustomerService;

        public OrderService(INotifyCustomerService notifyCustomerService)
        {
            _notifyCustomerService = notifyCustomerService;
        }

        public void Checkout(Cart cart, Payment payment)
        {

            ChargeCard(payment, cart);
            _notifyCustomerService.NotifyCustomer(cart);
        }

        private void ChargeCard(Payment payment, Cart cart)
        {
            //Charge                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              eCard ;
            return;
        }
    }
}
