using FM_1;
using FM1;

namespace FM_1

{
    public class CryptocurrencyPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
           
            return new CryptoCurrencyPayment();
        }
    }

  
}
