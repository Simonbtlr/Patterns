namespace Patterns.GeneratingPatterns.Builder.Pattern;

/// <summary>
/// Распорядитель - создает объект, используя объекты Builder
/// </summary>
public class Director
{
    private readonly Builder _builder;

    public Director(Builder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}