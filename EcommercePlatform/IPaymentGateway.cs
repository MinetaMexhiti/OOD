using System;

namespace FactoryMethod_1
{
    public abstract class IPaymentGateway
    {
        public abstract void ProcessofPayment(double amount);
    }

    //creditcard
    public class CreditCardPayment : IPaymentGateway
    {
        public override void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment  ${amount}");

           
            bool paymentSuccess = SimulateCreditCardProcessing(amount);

            if (paymentSuccess)
            {
                Console.WriteLine("Payment successful");
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }

        private bool SimulateCreditCardProcessing(double amount)
        {
           
            var response = MakeCreditCardApiRequest(amount);

            //i assume payment is successful
            return response == "success";
        }

        private string MakeCreditCardApiRequest(double amount)
        {
           
            Console.WriteLine($"Simulating API request to credit card payment gateway for payment o ${amount}");

            return "success";
        }
    }


    //PayPal
    public class PayPalPayment : IPaymentGateway
    {
        public override void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            bool paymentSuccess = SimulatePayPalProcessing(amount);

            if (paymentSuccess)
            {
                Console.WriteLine("Payment successful");
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }

        private bool SimulatePayPalProcessing(double amount)
        {
           
            var response = MakePayPalApiRequest(amount);

           
            return response == "success";
        }

        private string MakePayPalApiRequest(double amount)
        {
           
            Console.WriteLine($"Simulating API request to PayPal payment gateway for payment of ${amount}");

            return "success";
        }
    }


    //cash
    public class CashonDeliveryPayment : IPaymentGateway
    {
        public override void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Processing Cash payment of ${amount}");

            Console.WriteLine($"Please pay the delivery person in CASH upon delivery  ${amount}");
        }
    }

    public class CryptocurrencyPayment : IPaymentGateway
    {
        public override void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Processing Crypto payment of ${amount}");


            Console.WriteLine($"Please transfer the cryptocurrency amount to the provided wallet adddress ${amount}");
        }

    }
}
