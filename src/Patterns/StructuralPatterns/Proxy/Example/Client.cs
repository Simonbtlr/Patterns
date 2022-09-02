using System;

namespace Patterns.StructuralPatterns.Proxy.Example;

public class Client
{
    public void Main()
    {
        using var book = new BookStoreProxy() as IBook;

        var page1 = book.GetPage(1);
        Console.WriteLine(page1.Text);

        var page2 = book.GetPage(2);
        Console.WriteLine(page2.Text);

        page1 = book.GetPage(1);
        Console.WriteLine(page1.Text);
    }
}