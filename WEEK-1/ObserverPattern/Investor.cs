using System;

namespace ObserverPattern
{
    public class Investor : IObserver
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(string stockName, double price)
        {
            Console.WriteLine($"{name} received update: {stockName} price is ₹{price}");
        }
    }
}