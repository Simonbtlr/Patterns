namespace Patterns.Iterator;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}