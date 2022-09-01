namespace Patterns.BehaviorPatterns.Template.Pattern;

/// <summary>
/// Определяет шаблонный метод.
/// </summary>
public abstract class AbstractClass
{
    /// <summary>
    /// Шаблонный метод, который реализует алогоритм.
    /// Алгоритм может состоять из последовательных вызовов других
    /// методов, часть из которых может быть абстрактными и должны
    /// быть переопределены в классах-наследниках. При этом данный
    /// метод, представляющий структуру алгоритма, переопределяться
    /// не должен
    /// </summary>
    public void TemplateMethod()
    {
        Operation1();
        Operation2();
    }

    public abstract void Operation1();
    public abstract void Operation2();
}