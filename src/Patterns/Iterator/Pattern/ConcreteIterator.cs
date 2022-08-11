namespace Patterns.Iterator.Pattern;

/// <summary>
/// Конкретная реализация итератора для обхода объекта Aggregate.
/// Для фиксации индекса текущего перебираемого элемента использует
/// целочисленную переменную _current.
/// </summary>
public class ConcreteIterator : Iterator
{
    private readonly Aggregate _aggregate;
    private int _current;

    public ConcreteIterator(Aggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public override object First() =>
        _aggregate[0];

    public override object? Next()
    {
        object? ret = null;

        if (_current++ < _aggregate.Count)
            ret = _aggregate[_current];

        return ret;
    }

    public override bool IsDone() =>
        _current >= _aggregate.Count;

    public override object CurrentItem() =>
        _aggregate[_current];
}