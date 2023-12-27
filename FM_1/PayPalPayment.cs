using FM_1;
// For real implementation, I need to use PayPal's SDK or REST API


namespace FM_1
{
    public class PayPalPayment : IPaymentGateway
    {
        public void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Attempting to process PayPal payment for amount: ${amount}");

            try
            {
                
                var response = SimulatePayPalApiRequest(amount);

                if (response == "Success")
                {
                    Console.WriteLine("PayPal payment processed successfully.");
                }
                else
                {
                    Console.WriteLine("PayPal payment failed.");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing PayPal payment: {ex.Message}");
                
            }
        }

        private string SimulatePayPalApiRequest(double amount)
        {
            

            Console.WriteLine($"Simulating API request to PayPal for payment of ${amount}");

           
            if (amount < 100) 
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