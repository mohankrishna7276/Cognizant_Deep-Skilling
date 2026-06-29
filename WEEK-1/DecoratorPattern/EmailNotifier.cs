using System;

namespace DecoratorPattern
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Notification : {message}");
        }
    }
}