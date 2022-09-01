namespace Patterns.BehaviorPatterns.Iterator.Example;

public class Client
{
    public void Main()
    {
        var library = new Library();
        var reader = new Reader();

        reader.SeeBooks(library);
    }
}