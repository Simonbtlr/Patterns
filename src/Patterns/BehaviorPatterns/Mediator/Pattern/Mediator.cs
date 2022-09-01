namespace Patterns.BehaviorPatterns.Mediator.Pattern;

/// <summary>
/// Интерфейс для взаимодействия с объектами Colleague
/// </summary>
public abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}