using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Builder Pattern Example =====");

            Director director = new Director();

            IComputerBuilder builder = new GamingComputerBuilder();

            director.BuildComputer(builder);

            Computer computer = builder.GetComputer();

            computer.Display();
        }
    }
}