using System.Collections.Generic;
using System.Linq;

namespace Patterns.StructuralPatterns.Proxy.Example;

public class BookStoreProxy : IBook
{
    private List<Page> _pages;
    private BookStore _bookStore;

    public BookStoreProxy()
    {
        _pages = new List<Page>();
    }

    public Page GetPage(int number)
    {
        var page = _pages.FirstOrDefault(x => x.Number == number);

        if (page is not null)
            return page;

        page = (_bookStore ??= new BookStore())
            .GetPage(number);
        _pages.Add(page);

        return page;
    }

    public void Dispose() =>
        _bookStore?.Dispose();
}