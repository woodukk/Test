using System;

namespace TestProject
{
    public class StandardFigureFactory : IStandardFigureFactory
    {
        public IFigure CreateCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }

            return new Circle(radius);
        }

        public ITriangle CreateTriangle(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            if (a > b + c || b > a + c || c > a + b)
            {
                throw new ArgumentException("С такими величинами невозможно построить треугольник");
            }

            return new Triangle(a, b, c);
        }
    }
}