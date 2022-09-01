namespace Patterns.BehaviorPatterns.Observer.Example;

public class Client
{
    public void Main()
    {
        var stock = new Stock();
        var bank = new Bank("ЮнитБанк", stock);
        var broker = new Broker("Иван Иваныч", stock);

        stock.Market();
        broker.StopTrade();
        stock.Market();
    }
}