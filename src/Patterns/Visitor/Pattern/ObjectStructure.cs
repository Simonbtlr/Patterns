namespace Patterns.Visitor.Pattern;

/// <summary>
/// Некая структура, которая хранит объекты Element
/// и предоставляет к ним доступ. Это могут быть
/// и простые списки, и сложные составные структуры
/// в виде деревьев.
/// </summary>
public class ObjectStructure
{
    private List<Element> _elements = new();

    public void Add(Element element) => 
        _elements.Add(element);

    public void Remove(Element element) => 
        _elements.Remove(element);

    public void Accept(Visitor visitor)
    {
        foreach (var element in _elements)
            element.Accept(visitor);
    }
}