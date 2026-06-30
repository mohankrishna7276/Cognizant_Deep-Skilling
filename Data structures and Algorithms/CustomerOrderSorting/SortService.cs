using System;

namespace CustomerOrderSorting
{
    public class SortService
    {
        // Bubble Sort
        public void BubbleSort(Order[] orders)
        {
            int n = orders.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orders[j].Amount > orders[j + 1].Amount)
                    {
                        Order temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }
        }

        // Insertion Sort
        public void InsertionSort(Order[] orders)
        {
            for (int i = 1; i < orders.Length; i++)
            {
                Order key = orders[i];
                int j = i - 1;

                while (j >= 0 && orders[j].Amount > key.Amount)
                {
                    orders[j + 1] = orders[j];
                    j--;
                }

                orders[j + 1] = key;
            }
        }

        public void Display(Order[] orders)
        {
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            foreach (Order order in orders)
            {
                Console.WriteLine($"Order ID : {order.OrderId}");
                Console.WriteLine($"Customer : {order.CustomerName}");
                Console.WriteLine($"Amount   : ₹{order.Amount}");
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}