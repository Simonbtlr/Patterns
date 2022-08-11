namespace Patterns.Iterator.Example;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}