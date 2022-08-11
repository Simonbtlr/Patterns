namespace Patterns.Visitor.Example;

public class Bank
{
    private List<IAccount> _accounts = new();

    public void Add(IAccount acc) =>
        _accounts.Add(acc);

    public void Remove(IAccount acc) =>
        _accounts.Remove(acc);

    public void Accept(IVisitor visitor)
    {
        foreach (var account in _accounts)
            account.Accept(visitor);
    }
}