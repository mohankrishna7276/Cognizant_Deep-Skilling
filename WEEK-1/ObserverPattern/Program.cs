using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Observer Pattern Example =====\n");

            StockMarket stock = new StockMarket("TCS");

            Investor investor1 = new Investor("Mohan");
            Investor investor2 = new Investor("Rahul");
            Investor investor3 = new Investor("Priya");

            stock.Attach(investor1);
            stock.Attach(investor2);
            stock.Attach(investor3);

            Console.WriteLine("Stock Price Changed to ₹3850\n");
            stock.SetPrice(3850);

            Console.WriteLine("\nRemoving Rahul...\n");

            stock.Detach(investor2);

            Console.WriteLine("Stock Price Changed to ₹3925\n");
            stock.SetPrice(3925);
        }
    }
}