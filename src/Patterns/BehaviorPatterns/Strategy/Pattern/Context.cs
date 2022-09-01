namespace Patterns.BehaviorPatterns.Strategy.Pattern;

/// <summary>
/// Класс хранит ссылку на объект IStrategy и связан
/// с интерфейсом IStrategy отношением агрегации.
/// </summary>
public class Context
{
    public IStrategy Strategy { get; set; }

    public Context(IStrategy strategy)
    {
        Strategy = strategy;
    }

    public void ExecuteAlgorithm() =>
        Strategy.Algorithm();
}