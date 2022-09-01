namespace Patterns.BehaviorPatterns.Visitor.Pattern;

/// <summary>
/// Конкретный элемент реализующий метод Accept()
/// </summary>
public class ElementB : Element
{
    public override void Accept(Visitor visitor) =>
        visitor.VisitElementB(this);

    public void OperationB()
    {
    }
}