namespace Patterns.GeneratingPatterns.Builder.Pattern;

/// <summary>
/// Конкретная реализация Buildera. Создает объект Product
/// и определяет интерфейс для доступа к нему
/// </summary>
public class ConcreteBuilder : Builder
{
    private readonly Product _product = new();

    public override void BuildPartA() =>
        _product.Add("Part A");

    public override void BuildPartB() =>
        _product.Add("Part B");

    public override void BuildPartC() =>
        _product.Add("Part C");

    public override Product GetResult() =>
        _product;
}