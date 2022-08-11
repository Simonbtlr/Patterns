using Patterns.Strategy;
using Patterns.UnitTests.Common.TestFactories;

namespace Patterns.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Can_modify_car()
    {
        // Arrange
        var auto = CarTestFactory.MakeDefaultCar(
            movable: new PetrolMove());
        
        auto.Move();
        auto.Movable = new ElectricMove();
        
        // Act
        var result = () => auto.Move();
        
        // Assert
        result
            .Should()
            .NotThrow();
    }
}