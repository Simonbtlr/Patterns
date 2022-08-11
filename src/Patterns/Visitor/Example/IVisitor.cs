namespace Patterns.Visitor.Example;

public interface IVisitor
{
    void VisitPersonAcc(Person acc);
    void VisitCompanyAcc(Company acc);
}