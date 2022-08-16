namespace Patterns.GeneratingPatterns.Prototype.Pattern;

/// <summary>
/// Создает объекты прототипов с помощью метода Clone().
/// </summary>
public class Client
{
    public void Main()
    {
        var prototype = new ConcretePrototype1(1) as Prototype;
        var clone = prototype.Clone();
        prototype = new ConcretePrototype2(2);
        clone = prototype.Clone();
    }
}