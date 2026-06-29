using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton? instance;

        private static readonly object lockObject = new object();

        private Singleton()
        {
            Console.WriteLine("Singleton Object Created");
        }

        public static Singleton GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton Object");
        }
    }
}