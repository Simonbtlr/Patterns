namespace Patterns.GeneratingPatterns.FactoryMethod.Pattern;

/// <summary>
/// определяет абстрактный фабричный метод FactoryMethod(),
/// который возвращает объект Product.
/// </summary>
public abstract class Creator
{
    public abstract Product FactoryMethod();
}