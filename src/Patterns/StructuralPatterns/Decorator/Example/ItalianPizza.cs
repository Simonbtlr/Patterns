namespace Patterns.StructuralPatterns.Decorator.Example;

public class ItalianPizza : Pizza
{
    public ItalianPizza() : base("Итальянская пицца")
    {
    }

    public override int GetCost() => 10;
}