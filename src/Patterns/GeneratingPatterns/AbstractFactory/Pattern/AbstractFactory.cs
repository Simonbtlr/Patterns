namespace Patterns.GeneratingPatterns.AbstractFactory.Pattern;

/// <summary>
/// Определяет методы для создания объектов. Причем методы
/// возвращают абстрактные продукты, а не их конкретные реализации.
/// </summary>
public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}