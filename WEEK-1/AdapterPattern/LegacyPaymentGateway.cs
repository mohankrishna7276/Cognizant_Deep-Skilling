using System;

namespace AdapterPattern
{
    public class LegacyPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Legacy Payment Gateway processed payment of ₹{amount}");
        }
    }
}