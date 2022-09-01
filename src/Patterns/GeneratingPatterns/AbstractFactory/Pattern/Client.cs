namespace Patterns.GeneratingPatterns.AbstractFactory.Pattern;

/// <summary>
/// использует класс фабрики для создания объектов. При этом
/// он использует исключительно абстрактный класс фабрики AbstractFactory
/// и абстрактные классы продуктов AbstractProductA и AbstractProductB
/// и никак не зависит от их конкретных реализаций
/// </summary>
public class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    public Client(AbstractFactory factory)
    {
        _abstractProductA = factory.CreateProductA();
        _abstractProductB = factory.CreateProductB();
    }
}