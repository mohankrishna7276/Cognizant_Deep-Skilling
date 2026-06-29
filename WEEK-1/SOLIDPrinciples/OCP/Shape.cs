using System;

namespace SOLIDPrinciples.OCP
{
    /// <summary>
    /// Abstract base class for shapes
    /// Open for extension, closed for modification
    /// </summary>
    public abstract class Shape
    {
        public abstract double CalculateArea();
        
        public virtual void DisplayArea()
        {
            Console.WriteLine($"{this.GetType().Name} Area: {CalculateArea():F2}");
        }
    }
}
