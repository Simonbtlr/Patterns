namespace Patterns.BehaviorPatterns.Mediator.Pattern;

/// <summary>
/// Интерфейс для взаимодействия с объектом Mediator
/// </summary>
public abstract class Colleague
{
    protected readonly Mediator Mediator;

    protected Colleague(Mediator mediator)
    {
        Mediator = mediator;
    }
}