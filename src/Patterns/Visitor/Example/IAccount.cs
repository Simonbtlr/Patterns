namespace Patterns.Visitor.Example;

public interface IAccount
{
    void Accept(IVisitor visitor);
}