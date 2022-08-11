using Patterns.Iterator;
using Patterns.Iterator.Example;

namespace Patterns.UnitTests;

public class IteratorTests
{
    [Fact]
    public void Reader_can_see_books()
    {
        // Arrange
        var library = new Library();
        var reader = new Reader();
        
        // Act
        var result = () => reader.SeeBooks(library);
        
        // Assert
        result
            .Should()
            .NotThrow();
    }
}