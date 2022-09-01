namespace Patterns.BehaviorPatterns.Iterator.Example;

public interface IBookNumerable
{
    IBookIterator CreateNumerator();
    int Count { get; }
    Book this[int index] { get; }
}