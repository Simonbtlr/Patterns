namespace Patterns.Observer.Pattern;

/// <summary>
/// представляет наблюдателя, который подписывается
/// на все уведомления наблюдаемого объекта.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Вызывается наблюдаемым объектом для уведомления
    /// наблюдателя.
    /// </summary>
    void Update();
}