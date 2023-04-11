using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    internal class Payment
    {
        private IPaymentMethod? paymentMethod;

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void ProcessPayment(double amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
