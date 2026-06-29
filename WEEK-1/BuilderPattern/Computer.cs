using System;

namespace BuilderPattern
{
    public class Computer
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public void Display()
        {
            Console.WriteLine("\n===== Computer Configuration =====");
            Console.WriteLine($"Processor     : {Processor}");
            Console.WriteLine($"RAM           : {RAM}");
            Console.WriteLine($"Storage       : {Storage}");
            Console.WriteLine($"Graphics Card : {GraphicsCard}");
        }
    }
}