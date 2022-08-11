using Patterns.Mediator;
using Patterns.Mediator.Example;

namespace Patterns.UnitTests;

public class MediatorTests
{
    [Fact]
    public void Customer_can_notify_programmer()
    {
        // Arrange
        var mediator = new ManagerMediator();
        var customer = new CustomerColleague(mediator);
        var programmer = new ProgrammerColleague(mediator);
        var message = "Есть заказ, надо сделать программу";
        
        mediator.Customer = customer;
        mediator.Programmer = programmer;

        // Act
        var result = () => customer.Send(message);

        // Assert
        result
            .Should()
            .NotThrow();
    }
    
    [Fact]
    public void Programmer_can_notify_tester()
    {
        // Arrange
        var mediator = new ManagerMediator();
        var programmer = new ProgrammerColleague(mediator);
        var tester = new TesterColleague(mediator);
        var message = "Программа готова, надо протестировать";
        
        mediator.Programmer = programmer;
        mediator.Tester = tester;

        // Act
        var result = () => programmer.Send(message);

        // Assert
        result
            .Should()
            .NotThrow();
    }
    
    [Fact]
    public void Tester_can_notify_customer()
    {
        // Arrange
        var mediator = new ManagerMediator();
        var tester = new TesterColleague(mediator);
        var customer = new CustomerColleague(mediator);
        var message = "Программа протестирована и готова к продаже";
        
        mediator.Tester = tester;
        mediator.Customer = customer;

        // Act
        var result = () => tester.Send(message);

        // Assert
        result
            .Should()
            .NotThrow();
    }
}