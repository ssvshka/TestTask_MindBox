namespace ShapeAreas.Shapes;

public class Triangle : IShape
{
    private readonly double A;
    private readonly double B;
    private readonly double C;

    public Triangle(double a, double b, double c)
    {
        if (IsValid(a, b, c))
        {
            A = a;
            B = b;
            C = c;
        }

        else
        {
            throw new ArgumentException("This triangle cannot exist.");
        }
    }

    public double CalculateArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(
            p * (p - A) * (p - B) * (p - C));
    }

    private bool IsValid(double a, double b, double c) =>
        (a > 0 && b > 0 && c > 0) &&
        (a + b > c && b + c > a && a + c > b);

    public bool IsRightAngled() =>
        C * C == A * A + B * B ||
        A * A == B * B + C * C ||
        B * B == A * A + C * C;
}
