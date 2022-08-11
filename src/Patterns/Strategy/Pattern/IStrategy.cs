namespace Patterns.Strategy.Pattern;

/// <summary>
/// Общий интерфейс для всех реализующих его алгоритмов.
/// Вместо интерфейса можно использовать абстрактный
/// класс.
/// </summary>
public interface IStrategy
{
    void Algorithm();
}