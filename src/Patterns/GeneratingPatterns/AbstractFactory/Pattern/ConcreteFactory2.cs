namespace Patterns.GeneratingPatterns.AbstractFactory.Pattern;

/// <summary>
/// Реализует абстрактные методы базового класса и
/// непосредственно определяют какие конкретные продукты использовать
/// </summary>
public class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}