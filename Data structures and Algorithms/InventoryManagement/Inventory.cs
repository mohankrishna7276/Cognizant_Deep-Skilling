using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        // Add Product
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product Added Successfully.");
        }

        // View Products
        public void ViewProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Inventory is Empty.");
                return;
            }

            Console.WriteLine("\n------ Product List ------");

            foreach (Product product in products)
            {
                Console.WriteLine($"ID : {product.ProductId}");
                Console.WriteLine($"Name : {product.ProductName}");
                Console.WriteLine($"Price : ₹{product.Price}");
                Console.WriteLine($"Quantity : {product.Quantity}");
                Console.WriteLine("-------------------------");
            }
        }

        // Search Product
        public void SearchProduct(int id)
        {
            Product product = products.Find(p => p.ProductId == id);

            if (product != null)
            {
                Console.WriteLine("Product Found");

                Console.WriteLine($"ID : {product.ProductId}");
                Console.WriteLine($"Name : {product.ProductName}");
                Console.WriteLine($"Price : ₹{product.Price}");
                Console.WriteLine($"Quantity : {product.Quantity}");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        // Update Quantity
        public void UpdateQuantity(int id, int quantity)
        {
            Product product = products.Find(p => p.ProductId == id);

            if (product != null)
            {
                product.Quantity = quantity;

                Console.WriteLine("Quantity Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        // Delete Product
        public void DeleteProduct(int id)
        {
            Product product = products.Find(p => p.ProductId == id);

            if (product != null)
            {
                products.Remove(product);

                Console.WriteLine("Product Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }
    }
}