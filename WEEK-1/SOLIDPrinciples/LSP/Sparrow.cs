using System;

namespace SOLIDPrinciples.LSP
{
    /// <summary>
    /// Sparrow - a bird that can fly
    /// Correctly implements Bird interface
    /// </summary>
    public class Sparrow : Bird
    {
        public Sparrow(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating seeds");
        }

        public override void Fly()
        {
            Console.WriteLine($"{Name} is flying at low altitude");
        }
    }
}
