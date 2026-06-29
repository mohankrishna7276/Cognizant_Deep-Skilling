using System;

namespace SOLIDPrinciples.DIP
{
    /// <summary>
    /// Computer depends on IKeyboard abstraction, not concrete keyboard implementation
    /// Dependency Inversion: High-level modules should not depend on low-level modules
    /// Both should depend on abstractions
    /// </summary>
    public class Computer
    {
        private IKeyboard _keyboard;

        public Computer(IKeyboard keyboard)
        {
            _keyboard = keyboard;
        }

        public void Input(string text)
        {
            Console.WriteLine("Computer receiving input...");
            _keyboard.Type(text);
        }
    }
}
