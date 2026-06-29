using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Strategy Pattern Example =====\n");

            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("Customer chooses Credit Card");

            cart.SetPaymentStrategy(new CreditCardPayment());

            cart.Checkout(2500);

            Console.WriteLine();

            Console.WriteLine("Customer chooses UPI");

            cart.SetPaymentStrategy(new UpiPayment());

            cart.Checkout(1800);

            Console.WriteLine();

            Console.WriteLine("Customer chooses PayPal");

            cart.SetPaymentStrategy(new PayPalPayment());

            cart.Checkout(3200);
        }
    }
}