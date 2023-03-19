using ShapeAreas.Shapes;

namespace ShapeAreasTests;

public class AreAreasCalculated
{
    [Theory]
    [InlineData(2, 4, 5, 3.799671)]
    [InlineData(3, 6, 8, 7.644442)]
    public void TriangleAreaShouldCalculate(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);

        double actual = Math.Round(triangle.CalculateArea(), 6);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 78.539816)]
    [InlineData(1, 3.141593)]
    [InlineData(0, 0)]
    public void CircleAreaShouldCalculate(double radius, double expected)
    {
        var circle = new Circle(radius);

        double actual = Math.Round(circle.CalculateArea(), 6);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AreAreasCalculatedInCompileTime()
    {
        var circle = new Circle(0.5);
        var triangle = new Triangle(1, 2, 2);
        double actualArea = 0;

        var shapes = new List<IShape>
        {
            circle,
            triangle
        };

        foreach (var shape in shapes)
        {
            actualArea += shape.CalculateArea();
        }

        var expectedArea = 1.753644;

        Assert.Equal(expectedArea, Math.Round(actualArea, 6));
    }
}
