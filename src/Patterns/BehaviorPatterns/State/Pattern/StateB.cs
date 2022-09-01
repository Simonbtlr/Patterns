namespace Patterns.BehaviorPatterns.State.Pattern;

/// <summary>
/// Конкретная реализация состояния
/// </summary>
public class StateB : State
{
    public override void Handle(Context context) =>
        context.State = new StateA();
}