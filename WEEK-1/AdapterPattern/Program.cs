using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Adapter Pattern Example =====\n");

            IPaymentProcessor paymentProcessor = new PaymentAdapter();

            paymentProcessor.ProcessPayment(2500);

            Console.WriteLine("\nPayment completed successfully.");
        }
    }
}