using Patterns.GeneratingPatterns.Singleton.Example;

namespace Patterns.UnitTests;

public class SingletonTests
{
    [Fact]
    public void Singleton_works_in_one_thread()
    {
        // Arrange
        var comp = new Computer();

        // Act
        comp.Launch("Mac OS");

        // Assert
        comp.OS?.Name
            .Should()
            .Be("Mac OS");
    }

    [Fact]
    public void Singleton_works_with_multiple_threads()
    {
        new Thread(() =>
        {
            // Arrange
            var comp = new Computer();

            // Act
            comp.OS = OS.GetInstance("Mac OS");

            // Assert
            comp.OS?.Name
                .Should()
                .Be("Mac OS");
        }).Start();

        // Arrange
        var comp = new Computer();

        // Act
        comp.OS = OS.GetInstance("Windows");

        // Assert
        comp.OS?.Name
            .Should()
            .Be("Windows");
    }
}