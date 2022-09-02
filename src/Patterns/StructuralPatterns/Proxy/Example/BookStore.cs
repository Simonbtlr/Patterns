using System;
using System.Linq;

namespace Patterns.StructuralPatterns.Proxy.Example;

public class BookStore : IBook
{
    private readonly PageContext _pageContext;

    public BookStore()
    {
        _pageContext = new PageContext();
    }

    public Page GetPage(int number) =>
        _pageContext.Pages.FirstOrDefault(x => x.Number == number);

    public void Dispose() =>
        GC.Collect();
}