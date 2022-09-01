namespace Patterns.BehaviorPatterns.Command.Pattern;

/// <summary>
/// Конкретая реализация команды, реализует метод Execute(),
/// в котором вызывается определенный метод, определенный
/// в классе Receiver.
/// </summary>
public class ConcreteCommand : Command
{
    private Receiver _receiver;

    public ConcreteCommand(Receiver receiver)
    {
        _receiver = receiver;
    }

    public override void Execute() =>
        _receiver.Operation();

    public override void Undo()
    {
    }
}