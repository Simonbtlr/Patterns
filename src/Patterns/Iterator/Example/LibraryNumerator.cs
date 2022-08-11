namespace Patterns.Iterator.Example;

public class LibraryNumerator : IBookIterator
{
    private IBookNumerable _aggregate;

    private int _index;

    public LibraryNumerator(IBookNumerable aggregate)
    {
        _aggregate = aggregate;
    }

    public bool HasNext() =>
        _index < _aggregate.Count;

    public Book Next() =>
        _aggregate[_index++];
}