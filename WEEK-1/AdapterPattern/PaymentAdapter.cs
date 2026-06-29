namespace AdapterPattern
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentGateway legacyGateway;

        public PaymentAdapter()
        {
            legacyGateway = new LegacyPaymentGateway();
        }

        public void ProcessPayment(decimal amount)
        {
            legacyGateway.MakePayment(amount);
        }
    }
}