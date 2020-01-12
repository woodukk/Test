namespace TestProject
{
    public interface IStandardFigureFactory
    {
        IFigure CreateCircle(double radius);

        ITriangle CreateTriangle(double a, double b, double c);
    }
}