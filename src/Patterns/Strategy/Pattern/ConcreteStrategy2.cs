namespace Patterns.Strategy.Pattern;

/// <summary>
/// Класс, реализующий интерфейс IStrategy, предоставляя
/// свою версию метода Algorithm().
/// Подобных классов-реализаций может быть множество.
/// </summary>
public class ConcreteStrategy2 : IStrategy
{
    public void Algorithm() { }
}