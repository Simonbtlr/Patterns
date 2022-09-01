namespace Patterns.GeneratingPatterns.Builder.Pattern;

/// <summary>
/// Определяет интерфейс для создания различных частей объекта Product
/// </summary>
public abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    public abstract Product GetResult();
}