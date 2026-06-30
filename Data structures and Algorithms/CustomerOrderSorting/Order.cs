namespace CustomerOrderSorting
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public double Amount { get; set; }

        public Order(int id, string name, double amount)
        {
            OrderId = id;
            CustomerName = name;
            Amount = amount;
        }
    }
}