namespace Patterns.BehaviorPatterns.Visitor.Pattern;

/// <summary>
/// Конкретный элемент реализующий метод Accept()
/// </summary>
public class ElementA : Element
{
    public override void Accept(Visitor visitor) =>
        visitor.VisitElementA(this);

    public void OperationA()
    {
    }
}