using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop",65000),
                new Product(102,"Mobile",25000),
                new Product(103,"Keyboard",1500),
                new Product(104,"Mouse",700),
                new Product(105,"Monitor",12000)
            };

            SearchService search = new SearchService();

            Console.WriteLine("===== E-Commerce Search =====");

            Console.Write("Enter Product ID : ");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Linear Search");

            Product result1 = search.LinearSearch(products,id);

            if(result1 != null)
            {
                Console.WriteLine($"Product : {result1.ProductName}");
                Console.WriteLine($"Price : ₹{result1.Price}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("Binary Search");

            Product result2 = search.BinarySearch(products,id);

            if(result2 != null)
            {
                Console.WriteLine($"Product : {result2.ProductName}");
                Console.WriteLine($"Price : ₹{result2.Price}");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
    }
}