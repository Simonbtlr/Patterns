namespace Patterns.BehaviorPatterns.State.Pattern;

/// <summary>
/// Представляет объект, поведение которого должно
/// динамически изменяться в соответствии с состоянием.
/// Выполнение же конкретных действий делегируется
/// объекту состояния.
/// </summary>
public class Context
{
    public State State { get; set; }

    public Context(State state)
    {
        State = state;
    }

    public void Request() =>
        State.Handle(this);
}