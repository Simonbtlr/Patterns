namespace Patterns.Observer.Pattern;

/// <summary>
/// Представляет наблюдаемый объект.
/// </summary>
public interface IObservable
{
    /// <summary>
    /// Добавление наблюдателя
    /// </summary>
    /// <param name="o">Наблюдатель</param>
    void AddObserver(IObserver o);
    
    /// <summary>
    /// Удаление наблюдателя
    /// </summary>
    /// <param name="o">Наблюдатель</param>
    void RemoveObserver(IObserver o);
    
    /// <summary>
    /// Уведомление наблюдателей
    /// </summary>
    void NotifyObservers();
}