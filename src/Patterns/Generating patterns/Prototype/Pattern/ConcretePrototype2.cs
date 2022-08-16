namespace Patterns.Generating_patterns.Prototype.Pattern;

/// <summary>
/// Конкретные реализации прототипа, реализующие метод
/// Clone().
/// </summary>
public class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(int id) : base(id)
    {
    }

    public override Prototype Clone() =>
        new ConcretePrototype2(Id);
}