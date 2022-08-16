using Patterns.Generating_patterns.Prototype.Example;

namespace Patterns.UnitTests;

public class PrototypeTests
{
    [Fact]
    public void Deep_copy_successful_case()
    {
        // Arrange
        var figure = new Circle(
            radius: 30,
            x: 50,
            y: 60);

        // Act
        var result = figure.DeepCopy() as Circle;

        // Assert
        result?.Point
            .Should()
            .BeEquivalentTo(figure.Point);
    }
}