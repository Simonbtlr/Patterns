namespace Patterns.State.Pattern;

/// <summary>
/// Определяет интерфейс состояния
/// </summary>
public abstract class State
{
    public abstract void Handle(Context context);
}