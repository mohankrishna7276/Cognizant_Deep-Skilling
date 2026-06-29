using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockMarket : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private string stockName;
        private double price;

        public StockMarket(string stockName)
        {
            this.stockName = stockName;
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
            Notify();
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(stockName, price);
            }
        }
    }
}