using System;

namespace TestProject
{
    internal class Circle : IFigure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}