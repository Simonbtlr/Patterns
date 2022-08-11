using Patterns.Strategy;
using Patterns.Strategy.Example;
using Patterns.UnitTests.Common.TestFactories;

namespace Patterns.UnitTests;

public class StrategyTests
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