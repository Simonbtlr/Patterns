namespace Patterns.State.Pattern;

/// <summary>
/// Конкретная реализация состояния
/// </summary>
public class StateA : State
{
    public override void Handle(Context context) =>
        context.State = new StateB();
}