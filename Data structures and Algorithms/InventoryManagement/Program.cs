using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\n===== Inventory Management =====");

                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Update Quantity");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");

                Console.Write("Enter Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Product product = new Product();

                        Console.Write("Enter Product ID : ");
                        product.ProductId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Product Name : ");
                        product.ProductName = Console.ReadLine();

                        Console.Write("Enter Price : ");
                        product.Price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Quantity : ");
                        product.Quantity = Convert.ToInt32(Console.ReadLine());

                        inventory.AddProduct(product);

                        break;

                    case 2:

                        inventory.ViewProducts();

                        break;

                    case 3:

                        Console.Write("Enter Product ID : ");

                        int searchId = Convert.ToInt32(Console.ReadLine());

                        inventory.SearchProduct(searchId);

                        break;

                    case 4:

                        Console.Write("Enter Product ID : ");

                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New Quantity : ");

                        int quantity = Convert.ToInt32(Console.ReadLine());

                        inventory.UpdateQuantity(updateId, quantity);

                        break;

                    case 5:

                        Console.Write("Enter Product ID : ");

                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        inventory.DeleteProduct(deleteId);

                        break;

                    case 6:

                        Console.WriteLine("Thank You!");

                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");

                        break;
                }
            }
        }
    }
}