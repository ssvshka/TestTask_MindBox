namespace ShapeAreas.Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (IsValid(radius))
        {
            _radius = radius;
        }
        
        else
        {
            throw new ArgumentException("Circle radius can not be negative.");
        }
    }

    public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);

    private bool IsValid(double radius) => radius >= 0;
}
