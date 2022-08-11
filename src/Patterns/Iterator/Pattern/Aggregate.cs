namespace Patterns.Iterator.Pattern;

/// <summary>
/// Определяет интерфейс для создания объекта-итератора
/// </summary>
public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
    public abstract int Count { get; protected set; }
    public abstract object? this[int index] { get; set; }
}