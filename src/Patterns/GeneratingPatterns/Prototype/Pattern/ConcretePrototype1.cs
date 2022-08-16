namespace Patterns.GeneratingPatterns.Prototype.Pattern;

/// <summary>
/// Конкретные реализации прототипа, реализующие метод
/// Clone().
/// </summary>
public class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(int id) : base(id)
    {
    }

    public override Prototype Clone() =>
        new ConcretePrototype1(Id);
}