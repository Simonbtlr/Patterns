namespace Patterns.GeneratingPatterns.FactoryMethod.Pattern;

/// <summary>
/// Наследник класса Creator, определяющий свою реализацию
/// метода FactoryMethod(). Причем метод FactoryMethod()
/// каждого отдельного класса-создателя возвращает определенный
/// конкретный тип продукта. Для каждого конкретного класса
/// продукта определяется свой конкретный класс создателя.
/// </summary>
public abstract class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod() =>
        new ConcreteProductA();
}