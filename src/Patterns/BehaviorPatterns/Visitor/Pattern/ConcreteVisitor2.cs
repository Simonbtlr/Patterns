namespace Patterns.BehaviorPatterns.Visitor.Pattern;

/// <summary>
/// конкретный класс посетителя, реализует интерфейс,
/// определенный в Visitor.
/// </summary>
public class ConcreteVisitor2 : Visitor
{
    public override void VisitElementA(ElementA elementA) =>
        elementA.OperationA();

    public override void VisitElementB(ElementB elementB) =>
        elementB.OperationB();
}