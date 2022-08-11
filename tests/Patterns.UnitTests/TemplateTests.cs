using Patterns.Template;
using Patterns.Template.Example;

namespace Patterns.UnitTests;

public class TemplateTests
{
    [Fact]
    public void School_learn_successful_case()
    {
        // Arrange
        var school = new School();
        
        // Act
        var result = () => school.Learn();
        
        // Assert
        result
            .Should()
            .NotThrow();
    }

    [Fact]
    public void University_learn_successful_case()
    {
        // Arrange
        var university = new University();

        // Act
        var result = () => university.Learn();

        // Assert
        result
            .Should()
            .NotThrow();
    }
}