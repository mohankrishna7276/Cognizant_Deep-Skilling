using System;
using System.Collections.Generic;

namespace SOLIDPrinciples.SRP
{
    /// <summary>
    /// Represents an invoice with items and their quantities
    /// Single Responsibility: Only manages invoice data
    /// </summary>
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public string CustomerName { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public DateTime DateCreated { get; set; }

        public Invoice()
        {
            Items = new List<InvoiceItem>();
            DateCreated = DateTime.Now;
        }

        public void AddItem(string description, decimal price, int quantity)
        {
            Items.Add(new InvoiceItem { Description = description, Price = price, Quantity = quantity });
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }

    public class InvoiceItem
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
