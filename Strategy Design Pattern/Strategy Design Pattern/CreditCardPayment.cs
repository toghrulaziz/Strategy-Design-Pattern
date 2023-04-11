using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    internal class CreditCardPayment : IPaymentMethod
    {
        private string cardNumber;
        private string cvv;
        private string expiryDate;

        public CreditCardPayment(string cardNumber, string cvv, string expiryDate)
        {
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expiryDate = expiryDate;
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paying " + amount + " using credit card " + cardNumber);
        }
    }
}
