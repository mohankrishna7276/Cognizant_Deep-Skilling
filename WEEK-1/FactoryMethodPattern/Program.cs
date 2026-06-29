using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method Pattern ===\n");

            IDocument word = DocumentFactory.CreateDocument("word");
            word.Open();

            IDocument pdf = DocumentFactory.CreateDocument("pdf");
            pdf.Open();

            IDocument excel = DocumentFactory.CreateDocument("excel");
            excel.Open();
        }
    }
}