using System;

namespace SOLIDPrinciples.LSP
{
    /// <summary>
    /// Base Bird class
    /// Liskov Substitution: Derived types must be substitutable for their base types
    /// </summary>
    public abstract class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public abstract void Eat();
        public abstract void Fly();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Bird: {Name}");
        }
    }
}
