namespace Patterns.StructuralPatterns.Decorator.Example;

public abstract class PizzaDecorator : Pizza
{
    protected Pizza Pizza;

    protected PizzaDecorator(string name, Pizza pizza) : base(name)
    {
        Pizza = pizza;
    }
}