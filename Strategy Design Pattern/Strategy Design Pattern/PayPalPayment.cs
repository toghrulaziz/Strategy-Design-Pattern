using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    internal class PayPalPayment : IPaymentMethod
    {
        private string email;
        private string password;

        public PayPalPayment(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paying " + amount + " using PayPal account " + email);
        }

    }
}
