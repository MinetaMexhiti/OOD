using FM_1;

namespace FactoryMethod_1
{
    public class PayPalPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new PayPalPayment();
        }
    }
}
