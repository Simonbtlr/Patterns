namespace Patterns.Observer.Example;

public interface IObservable
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}