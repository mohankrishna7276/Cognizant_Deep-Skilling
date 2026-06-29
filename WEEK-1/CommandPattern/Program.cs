using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Command Pattern Example =====\n");

            // Receiver
            Light light = new Light();

            // Commands
            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            // Invoker
            RemoteControl remote = new RemoteControl();

            Console.WriteLine("Pressing ON Button");
            remote.SetCommand(lightOn);
            remote.PressButton();

            Console.WriteLine();

            Console.WriteLine("Pressing OFF Button");
            remote.SetCommand(lightOff);
            remote.PressButton();
        }
    }
}