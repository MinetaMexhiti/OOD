using FM_1;

namespace FM1
{
    public class CryptoCurrencyPayment : IPaymentGateway
    {
        public string GetWalletAddress()
        {
     
            return "sample_wallet_address";
        }

        public void ProcessofPayment(double amount)
        {
            throw new NotImplementedException();
        }

        public bool SendPayment(string walletAddress, double amount)
        {
            
            Console.WriteLine($"Initiating transaction to send ${amount} to wallet address: {walletAddress}");

           
            var transactionResult = ProcessTransaction(walletAddress, amount);

            return transactionResult;
        }

        private bool ProcessTransaction(string walletAddress, double amount)
        {
            
            if (amount <= 0)
            {
                Console.WriteLine("Transaction failed: Amount must be greater than zero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(walletAddress))
            {
                Console.WriteLine("Transaction failed: Invalid wallet address.");
                return false;
            }

           
            Console.WriteLine("Processing transaction...");
            System.Threading.Thread.Sleep(2000); 
           
            Console.WriteLine($"Transaction successful: ${amount} sent to {walletAddress}.");
            return true;
        }
    }
}