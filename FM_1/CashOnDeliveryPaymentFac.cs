using FM_1;

namespace FM_1

{
    public class CashonDeliveryPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
          
            return new CashonDeliveryPayment();
        }
    }
}
