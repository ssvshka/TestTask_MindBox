namespace ShapeAreasTests;

public class RightAngled_Tests
{
    [Fact]
    public void RightAngledTriangleCheck_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void NonRightAngledTriangleCheck_ReturnsFalse() 
    {
        var triangle = new Triangle(3, 4, 6);

        Assert.False(triangle.IsRightAngled());
    }
}
