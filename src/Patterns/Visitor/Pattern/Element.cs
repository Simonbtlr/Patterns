namespace Patterns.Visitor.Pattern;

/// <summary>
/// Определяет метод Accept(), в котором в качестве параметра
/// принимается объект Visitor
/// </summary>
public abstract class Element
{
    public abstract void Accept(Visitor visitor);
    public string SomeState { get; set; }
}