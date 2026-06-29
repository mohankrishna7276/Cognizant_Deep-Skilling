using System;

namespace SOLIDPrinciples.LSP
{
    /// <summary>
    /// Eagle - a bird that can fly
    /// Correctly implements Bird interface
    /// </summary>
    public class Eagle : Bird
    {
        public Eagle(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fish");
        }

        public override void Fly()
        {
            Console.WriteLine($"{Name} is flying at high altitude");
        }
    }
}
