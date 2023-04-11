namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment();

            IPaymentMethod creditCardPayment = new CreditCardPayment("1234-5678-9012-3456", "123", "06/24");
            IPaymentMethod payPalPayment = new PayPalPayment("hakunamatata@gmail.com", "password");

            payment.SetPaymentMethod(creditCardPayment);
            payment.ProcessPayment(100);

            payment.SetPaymentMethod(payPalPayment);
            payment.ProcessPayment(50);
        }
    }
}