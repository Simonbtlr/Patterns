namespace Patterns.BehaviorPatterns.Iterator.Example;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}