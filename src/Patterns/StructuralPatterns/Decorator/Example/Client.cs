using System;

namespace Patterns.StructuralPatterns.Decorator.Example;

public class Client
{
    public void Main()
    {
        var pizza1 = new ItalianPizza() as Pizza;
        pizza1 = new TomatoPizza(pizza1);

        Console.WriteLine($"Название: {pizza1.Name}");
        Console.WriteLine($"Цена: {pizza1.GetCost()}");

        var pizza2 = new ItalianPizza() as Pizza;
        pizza2 = new CheesePizza(pizza2);

        Console.WriteLine($"Название: {pizza2.Name}");
        Console.WriteLine($"Цена: {pizza2.GetCost()}");

        var pizza3 = new BulgarianPizza() as Pizza;
        pizza3 = new TomatoPizza(pizza3);
        pizza3 = new CheesePizza(pizza3);

        Console.WriteLine($"Название: {pizza3.Name}");
        Console.WriteLine($"Цена: {pizza3.GetCost()}");
    }
}