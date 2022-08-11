namespace Patterns.Visitor.Pattern;

public class Client
{
    void Main()
    {
        var structure = new ObjectStructure();
        structure.Add(new ElementA());
        structure.Add(new ElementB());
        structure.Accept(new ConcreteVisitor1());
        structure.Accept(new ConcreteVisitor2());
    }
}