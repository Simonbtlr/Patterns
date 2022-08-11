using System.Collections;

namespace Patterns.Iterator.Pattern;

/// <summary>
/// Конкретная реализация Aggregate. Хранит эелементы,
/// которые надо будет перебирать.
/// </summary>
public class ConcreteAggregate : Aggregate
{
    private readonly ArrayList _items = new();

    public override Iterator CreateIterator() =>
        new ConcreteIterator(this);

    public override int Count
    {
        get => _items.Count;
        protected set { }
    }

    public override object? this[int index]
    {
        get => _items[index];
        set => _items.Insert(index, value);
    }
}