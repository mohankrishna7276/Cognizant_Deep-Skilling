namespace EcommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
        }
    }
}