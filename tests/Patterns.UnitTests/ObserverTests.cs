using Patterns.Observer.Example;

namespace Patterns.UnitTests;

public class ObserverTests
{
    [Fact]
    public void Stock_can_continue_works_without_broker()
    {
        // Arrange
        var stock = new Stock();
        var broker = new Broker("Иван Иваныч", stock);
        
        stock.Market();
        broker.StopTrade();

        var result = () => stock.Market();

        result
            .Should()
            .NotThrow();
    }
}