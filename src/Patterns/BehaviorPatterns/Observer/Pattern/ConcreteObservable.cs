using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Observer.Pattern;

/// <summary>
/// Конкретная реализация интерфейса IObservable.
/// Определяет коллекцию объектов наблюдателей.
/// </summary>
public class ConcreteObservable : IObservable
{
    private List<IObserver> _observers;

    public ConcreteObservable()
    {
        _observers = new List<IObserver>();
    }

    public void AddObserver(IObserver o) =>
        _observers.Add(o);

    public void RemoveObserver(IObserver o) =>
        _observers.Remove(o);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
            observer.Update();
    }
}