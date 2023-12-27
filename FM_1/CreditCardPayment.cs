using FM_1;

namespace FM_1
{
    public class CreditCardPayment : IPaymentGateway
    {
        public void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Attempting to process credit card payment for amount: ${amount}");

            try
            {
               
                var response = SimulateCreditCardApiRequest(amount);

                if (response == "Success")
                {
                    Console.WriteLine("Credit card payment processed successfully.");
                }
                else
                {
                    Console.WriteLine("Credit card payment failed.");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing payment: {ex.Message}");
               
            }
        }

        private string SimulateCreditCardApiRequest(double amount)
        {
            

            Console.WriteLine($"Simulating API request for payment of ${amount}");
            if (amount < 50)
            {
                return "Success";
            }
            else
            {
               
                return "Failed";
            }
        }
    }
}