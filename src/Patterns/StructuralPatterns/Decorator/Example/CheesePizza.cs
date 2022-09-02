namespace Patterns.StructuralPatterns.Decorator.Example;

public class CheesePizza : PizzaDecorator
{
    public CheesePizza(Pizza pizza)
        : base($"{pizza.Name}, c сыром", pizza)
    {
    }

    public override int GetCost() =>
        Pizza.GetCost() + 5;
}