namespace Patterns.Observer.Example;

public class Bank : IObserver
{
    public string Name { get; set; }

    private IObservable _stock;

    public Bank(string name, IObservable observable)
    {
        Name = name;
        _stock = observable;
        
        _stock.RegisterObserver(this);
    }
    
    public void Update(object obj)
    {
        var stockInfo = (StockInfo)obj;
        
        Console.WriteLine(
            stockInfo.Euro > 40 
            ? $"Банк {Name} продает евро; Курс евро {stockInfo.Euro}"
            : $"Банк {Name} покупает евро; Курс евро {stockInfo.Euro}");
    }
}