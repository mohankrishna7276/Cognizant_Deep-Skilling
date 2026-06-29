using System;

namespace SOLIDPrinciples.DIP
{
    /// <summary>
    /// Concrete implementation of keyboard
    /// </summary>
    public class MechanicalKeyboard : IKeyboard
    {
        public void Type(string text)
        {
            Console.WriteLine($"Mechanical Keyboard typing: {text}");
        }
    }
}
