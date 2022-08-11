using Patterns.State.Example;

namespace Patterns.UnitTests;

public class State
{
    [Fact]
    public void Solid_to_liquid()
    {
        // Arrange
        var water = new Water(new SolidWaterState());

        // Act
        water.Heat();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(LiquidWaterState));
    }

    [Fact]
    public void Liquid_to_gas()
    {
        // Arrange
        var water = new Water(new LiquidWaterState());

        // Act
        water.Heat();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(GasWaterState));
    }

    [Fact]
    public void Gas_last_state()
    {
        // Arrange
        var water = new Water(new GasWaterState());

        // Act
        water.Heat();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(GasWaterState));
    }

    [Fact]
    public void Gas_to_liquid()
    {
        // Arrange
        var water = new Water(new GasWaterState());

        // Act
        water.Frost();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(LiquidWaterState));
    }

    [Fact]
    public void Liquid_to_solid()
    {
        // Arrange
        var water = new Water(new LiquidWaterState());

        // Act
        water.Frost();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(SolidWaterState));
    }

    [Fact]
    public void Solid_first_state()
    {
        // Arrange
        var water = new Water(new SolidWaterState());

        // Act
        water.Frost();

        // Assert
        water.State
            .Should()
            .BeOfType(typeof(SolidWaterState));
    }
}