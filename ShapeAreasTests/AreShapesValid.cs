namespace ShapeAreasTests;

public class AreShapesValid
{
    [Theory]
    [InlineData(-1, 2, 3)]
    [InlineData(0, 1, 1)]
    public void Triangle_WithZeroOrNegativeSides_ThrowsException(double a, double b, double c)
    {
        var triangle = () => new Triangle(a, b, c);

        Assert.Throws<ArgumentException>(triangle);
    }

    [Fact]
    public void Triangle_WithOneSideBiggerThanOtherTwo_ThrowsException()
    {
        var triangle = () => new Triangle(2, 4, 8);

        Assert.Throws<ArgumentException>(triangle);
    }

    [Fact]
    public void Circle_WithNegativeRadius_ThrowsException()
    {
        var circle = () => new Circle(-5);

        Assert.Throws<ArgumentException>(circle);
    }
}
