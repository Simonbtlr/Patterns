namespace Patterns.BehaviorPatterns.Visitor.Example;

public interface IAccount
{
    void Accept(IVisitor visitor);
}