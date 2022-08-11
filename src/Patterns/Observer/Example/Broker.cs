namespace Patterns.Observer.Example;

public class Broker : IObserver
{
    public string Name { get; set; }

    private IObservable? _stock;

    public Broker(string name, IObservable observable)
    {
        Name = name;
        _stock = observable;
        
        _stock.RegisterObserver(this);
    }
    
    public void Update(object obj)
    {
        var stockInfo = (StockInfo)obj;

        Console.WriteLine(
            stockInfo.Usd > 30 
                ? $"Брокер {Name} продает доллары; Курс доллара: {stockInfo.Usd}" 
                : $"Брокер {Name} покупает доллары; Курс доллара: {stockInfo.Usd}");
    }

    public void StopTrade()
    {
        _stock?.RemoveObserver(this);
        
        _stock = null;
    }
}