namespace Patterns.Iterator.Example;

public class Library : IBookNumerable
{
    private Book[] _books;

    public Library()
    {
        _books = new[]
        {
            new Book { Name = "Война и мир" },
            new Book { Name = "Отцы и дети" },
            new Book { Name = "Вишневый сад" }
        };
    }

    public int Count => 
        _books.Length;

    public Book this[int index] =>
        _books[index];

    public IBookIterator CreateNumerator() =>
        new LibraryNumerator(this);
}