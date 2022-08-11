using Patterns.Visitor.Example;

namespace Patterns.UnitTests;

public class VisitorTests
{
    [Fact]
    public void Bank_can_accept_html_visitor()
    {
        // Arrange
        var bank = new Bank();
        bank.Add(new Person
        {
            Name = "Иван Алексеев",
            Number = "82184931"
        });
        
        // Act
        var result = () => bank.Accept(new HtmlVisitor());
        
        // Assert
        result
            .Should()
            .NotThrow();
    }
    
    [Fact]
    public void Bank_can_accept_xml_visitor()
    {
        // Arrange
        var bank = new Bank();
        bank.Add(new Company
        {
            Name = "Microsoft",
            RegNumber = "ewuir32141324",
            Number = "3424131445"
        });
        
        // Act
        var result = () => bank.Accept(new XmlVisitor());
        
        // Assert
        result
            .Should()
            .NotThrow();
    }
}