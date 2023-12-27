using System;
using FactoryMethod_1;
using FM_1;


namespace FM_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IPaymentGatewayFac creditCardPaymentFactory = new CreditCardPaymentFac();
            IPaymentGatewayFac payPalPaymentFactory = new PayPalPaymentFac();
            IPaymentGatewayFac cashOnDeliveryPaymentFactory = new CashonDeliveryPaymentFac();
            IPaymentGatewayFac cryptocurrencyPaymentFactory = new CryptocurrencyPaymentFac();

         
            IPaymentGateway creditCardGateway = creditCardPaymentFactory.CreatePaymentGateway();
            IPaymentGateway payPalGateway = payPalPaymentFactory.CreatePaymentGateway();
            IPaymentGateway cashOnDeliveryGateway = cashOnDeliveryPaymentFactory.CreatePaymentGateway();
            IPaymentGateway cryptocurrencyGateway = cryptocurrencyPaymentFactory.CreatePaymentGateway();

            Console.WriteLine("Processing Credit Card Payment:");
            creditCardGateway.ProcessofPayment(100.00);
            Console.WriteLine("\nProcessing PayPal Payment:");
            payPalGateway.ProcessofPayment(50.00);
            Console.WriteLine("\nProcessing Cash on Delivery Payment:");
            cashOnDeliveryGateway.ProcessofPayment(30.00);
            Console.WriteLine("\nProcessing Cryptocurrency Payment:");
            cryptocurrencyGateway.ProcessofPayment(70.00);
        }
    }
}
