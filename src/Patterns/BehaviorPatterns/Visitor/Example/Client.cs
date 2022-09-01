namespace Patterns.BehaviorPatterns.Visitor.Example;

public class Client
{
    public void Main()
    {
        var structure = new Bank();

        structure.Add(new Person
        {
            Name = "Иван Алексеев",
            Number = "82184931"
        });

        structure.Add(new Company
        {
            Name = "Microsoft",
            RegNumber = "ewuir32141324",
            Number = "3424131445"
        });

        structure.Accept(new HtmlVisitor());
        structure.Accept(new XmlVisitor());
    }
}