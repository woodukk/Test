using System;

namespace TestProject
{
    internal class Triangle : ITriangle
    {
        private readonly double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            IsRight = Math.Pow(a, 2).Equals(Math.Pow(b, 2) + Math.Pow(c, 2)) ||
                      Math.Pow(b, 2).Equals(Math.Pow(a, 2) + Math.Pow(c, 2)) ||
                      Math.Pow(c, 2).Equals(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public double GetArea()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRight { get; }
    }
}