namespace Patterns.BehaviorPatterns.Visitor.Pattern;

/// <summary>
/// Интерфейс посетителя, который определяет метод
/// Visit() для каждого объекта Element.
/// </summary>
public abstract class Visitor
{
    public abstract void VisitElementA(ElementA elementA);
    public abstract void VisitElementB(ElementB elementB);
}