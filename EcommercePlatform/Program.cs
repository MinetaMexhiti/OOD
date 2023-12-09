using System;

namespace FactoryMethod_1
{
    class Program
    {
        static void Main(string[] Args)
        {
            
            IPaymentGatewayFac CreditCardPaymentFactory = new CreditCardPaymentFac();
            IPaymentGateway CreditCardGateway = new CreditCardPayment();

            IPaymentGatewayFac PayPalPaymentFactory = new PayPalPaymentFac();
            IPaymentGateway PayPalGateway = new PayPalPayment();

            IPaymentGatewayFac CashOnDeliveryPaymentFactory = new CashonDeliveryPaymentFac();
            IPaymentGateway CashonDeliveryGateway = new CashonDeliveryPayment();

            IPaymentGatewayFac CryptocurrencyPaymentFactory = new CryptocurrencyPaymentFac();
            IPaymentGateway CryptocurrencyGateway = new CryptocurrencyPayment();

            // Process payments
            ProcessofPayment(CreditCardGateway, 100.00);
            // Add some space or separator
            Console.WriteLine("-------------------------------");
            ProcessofPayment(PayPalGateway, 20.00);
            // Add some space or separator
            Console.WriteLine("-------------------------------");
            ProcessofPayment(CashonDeliveryGateway, 17.00);
            // Add some space or separator
            Console.WriteLine("-------------------------------");
            ProcessofPayment(CryptocurrencyGateway, 40.00);
        }

        private static void ProcessofPayment(IPaymentGateway paymentGateway, double amount)
        {
            // Demonstration of processing a payment
            paymentGateway.ProcessofPayment(amount);
        }
    }
}


