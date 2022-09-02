namespace Patterns.StructuralPatterns.Decorator.Example;

public class BulgarianPizza : Pizza
{
    public BulgarianPizza() : base("Болгарская пицца")
    {
    }

    public override int GetCost() => 8;
}