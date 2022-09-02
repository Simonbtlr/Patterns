namespace Patterns.StructuralPatterns.Decorator.Example;

public abstract class Pizza
{
    public string Name { get; protected set; }

    public Pizza(string name)
    {
        Name = name;
    }

    public abstract int GetCost();
}