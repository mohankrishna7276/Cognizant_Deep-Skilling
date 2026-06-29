using System;

namespace SOLIDPrinciples.SRP
{
    /// <summary>
    /// Responsible only for printing invoice data
    /// Single Responsibility: Only handles the printing logic
    /// </summary>
    public class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine("========== INVOICE ==========");
            Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
            Console.WriteLine($"Customer: {invoice.CustomerName}");
            Console.WriteLine($"Date: {invoice.DateCreated:yyyy-MM-dd}");
            Console.WriteLine("\n--- Items ---");

            foreach (var item in invoice.Items)
            {
                Console.WriteLine($"{item.Description}: ${item.Price} x {item.Quantity} = ${item.Price * item.Quantity}");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total: ${invoice.GetTotal():F2}");
            Console.WriteLine("============================\n");
        }
    }
}
