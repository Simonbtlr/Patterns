namespace Patterns.Iterator.Pattern;

/// <summary>
/// Использует объект Aggregate и итератор для его обхода.
/// </summary>
public class Client
{
    public void Main()
    {
        var a = new ConcreteAggregate();
        var i = a.CreateIterator();
        var item = i.First();

        while (!i.IsDone())
            item = i.Next();
    }    
}