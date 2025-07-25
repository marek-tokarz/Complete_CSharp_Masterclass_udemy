namespace InterfacesPolymorphismPaymentApp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            // Implementing credit card payment logic.
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
            // Implementing paypal payment logic.
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCarProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCarProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PaypalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
            
        }
    }
}
