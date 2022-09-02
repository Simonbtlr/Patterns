using System;

namespace Patterns.StructuralPatterns.Proxy.Example;

public interface IBook : IDisposable
{
    Page GetPage(int number);
}