namespace StrategyPattern
{
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Checkout(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}