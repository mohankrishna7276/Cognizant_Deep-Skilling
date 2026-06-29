using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Decorator Pattern Example =====\n");

            INotifier notifier = new EmailNotifier();

            Console.WriteLine("1. Email Notification");
            notifier.Send("Server is Running");

            Console.WriteLine("\n------------------------");

            Console.WriteLine("2. Email + SMS");

            notifier = new SMSNotifierDecorator(new EmailNotifier());

            notifier.Send("Database Backup Completed");

            Console.WriteLine("\n------------------------");

            Console.WriteLine("3. Email + SMS + Slack");

            notifier = new SlackNotifierDecorator(
                           new SMSNotifierDecorator(
                               new EmailNotifier()));

            notifier.Send("Deployment Successful");
        }
    }
}