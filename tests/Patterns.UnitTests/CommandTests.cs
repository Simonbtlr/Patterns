using Patterns.Command.Example;

namespace Patterns.UnitTests;

public class CommandTests
{
    [Fact]
    public void Pult_can_execute()
    {
        // Arrange
        var pult = new Pult();
        var tv = new TV();

        pult.SetCommand(new TVOnCommand(tv));

        // Act
        var result = () => pult.PressButton();

        // Assert
        result
            .Should()
            .NotThrow();
    }

    [Fact]
    public void Pult_can_undo()
    {
        // Arrange
        var pult = new Pult();
        var tv = new TV();

        pult.SetCommand(new TVOnCommand(tv));
        pult.PressButton();

        // Act
        var result = () => pult.PressUndo();

        // Assert
        result
            .Should()
            .NotThrow();
    }
}