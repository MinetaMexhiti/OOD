namespace FactoryMethod_1
{
    public interface IPaymentGatewayFac
	{
        public abstract  IPaymentGateway CreatePaymentGateway();
    }


    public class CreditCardPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new CreditCardPayment();
        }
    }

    public class PayPalPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new PayPalPayment();
        }
    }


    public class CashonDeliveryPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new CashonDeliveryPayment();
        }
    }


    public class CryptocurrencyPaymentFac : IPaymentGatewayFac
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new CryptocurrencyPayment();
        }
    }

}

