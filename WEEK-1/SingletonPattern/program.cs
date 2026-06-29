using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating First Object");

            Singleton obj1 = Singleton.GetInstance();
            obj1.ShowMessage();

            Console.WriteLine();

            Console.WriteLine("Creating Second Object");

            Singleton obj2 = Singleton.GetInstance();
            obj2.ShowMessage();

            Console.WriteLine();

            if (obj1 == obj2)
            {
                Console.WriteLine("Both objects are the same instance.");
            }
            else
            {
                Console.WriteLine("Objects are different.");
            }
        }
    }
}