using System.Collections.Generic;

namespace Patterns.GeneratingPatterns.Builder.Pattern;

/// <summary>
/// представляет объект, который должен быть создан.
/// В данном случае все части объекта заключены в списке parts.
/// </summary>
public class Product
{
    private readonly List<string> _parts = new();

    public void Add(string part) =>
        _parts.Add(part);
}