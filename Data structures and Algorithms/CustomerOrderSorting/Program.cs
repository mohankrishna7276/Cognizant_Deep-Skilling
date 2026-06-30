using System;

namespace CustomerOrderSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Order[] orders =
            {
                new Order(101,"Mohan",2500),
                new Order(102,"Rahul",1200),
                new Order(103,"Priya",5000),
                new Order(104,"Anjali",800),
                new Order(105,"Kiran",3500)
            };

            SortService sort = new SortService();

            Console.WriteLine("===== Customer Order Sorting =====");

            Console.WriteLine("\nOriginal Orders");
            sort.Display(orders);

            Console.WriteLine("\nChoose Sorting Algorithm");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");

            Console.Write("Enter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:

                    sort.BubbleSort(orders);

                    Console.WriteLine("\nOrders Sorted using Bubble Sort");

                    break;

                case 2:

                    sort.InsertionSort(orders);

                    Console.WriteLine("\nOrders Sorted using Insertion Sort");

                    break;

                default:

                    Console.WriteLine("Invalid Choice");

                    return;
            }

            sort.Display(orders);
        }
    }
}