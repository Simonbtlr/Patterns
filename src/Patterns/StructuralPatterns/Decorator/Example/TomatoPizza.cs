namespace Patterns.StructuralPatterns.Decorator.Example;

public class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza pizza)
        : base($"{pizza.Name}, c томатами", pizza)
    {
    }

    public override int GetCost() =>
        Pizza.GetCost() + 3;
}