namespace Patterns.Observer.Example;

public class Stock : IObservable
{
    private StockInfo _stockInfo;

    private List<IObserver> _observers;

    public Stock()
    {
        _observers = new List<IObserver>();
        _stockInfo = new StockInfo();
    }

    public void RegisterObserver(IObserver observer) =>
        _observers.Add(observer);

    public void RemoveObserver(IObserver observer) =>
        _observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
            observer.Update(_stockInfo);
    }

    public void Market()
    {
        _stockInfo.Usd = Random.Shared.Next(20, 40);
        _stockInfo.Euro = Random.Shared.Next(30, 50);
        
        NotifyObservers();
    }
}