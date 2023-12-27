using FM_1;

namespace FM_1

{
    public class CreditCardPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
           
            return new CreditCardPayment();
        }
    }
}
