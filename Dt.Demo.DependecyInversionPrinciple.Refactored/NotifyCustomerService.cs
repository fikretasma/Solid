using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.DependecyInversionPrinciple.Refactored
{
    public class NotifyCustomerService:INotifyCustomerService
    {
        public void NotifyCustomer(Cart cart) {
            string customerEmail = cart.CustomerEmail;
            if (string.IsNullOrEmpty(customerEmail))
            {
                //throw exception
                return;
            }

            using (var message = new MailMessage("fikret.asma@d-teknoloji.com.tr", customerEmail))
            using (var client = new SmtpClient("localhost"))
            {
                message.Subject = $"Siparişiniz :{DateTime.Now} tarihinde oluşturulmuştur";
                message.Body = $"Sipariş Detayı : {cart}";

                try
                {
                    client.Send(message);
                }
                catch (Exception exception)
                {
                    //log exception
                    throw;
                }
            }
        }
    }
}
