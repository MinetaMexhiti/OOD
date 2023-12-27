using FM_1;

namespace FM_1
{
    public interface IPaymentGatewayFac
    {
        IPaymentGateway CreatePaymentGateway();
    }
}
