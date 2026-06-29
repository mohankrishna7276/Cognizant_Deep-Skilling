using System;

namespace SOLIDPrinciples.OCP
{
    /// <summary>
    /// Circle implementation of Shape
    /// Extends Shape without modifying it
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
