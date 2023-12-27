using FM_1;

namespace FM_1
{
    public class CashonDeliveryPayment : IPaymentGateway
    {
        private readonly IOrderService _orderService;

        public CashonDeliveryPayment()
        {
        }

        public CashonDeliveryPayment(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void ProcessofPayment(double amount)
        {
            Console.WriteLine($"Order confirmed for Cash on Delivery. Prepare ${amount} in cash for payment upon delivery.");

         
            _orderService.UpdateOrderStatus("Awaiting Cash on Delivery");
            _orderService.NotifyDeliveryService();
        }
    }

    public interface IOrderService
    {
        void UpdateOrderStatus(string status);
        void NotifyDeliveryService();
    }

    public class OrderService : IOrderService
    {
        public void UpdateOrderStatus(string status)
        {
            Console.WriteLine($"Order status updated to: {status}");
        }

        public void NotifyDeliveryService()
        {
            Console.WriteLine("Delivery service notified for order preparation.");
        }
    }
}