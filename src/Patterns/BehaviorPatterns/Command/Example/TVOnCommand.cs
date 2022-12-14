namespace Patterns.BehaviorPatterns.Command.Example;

public class TVOnCommand : ICommand
{
    private TV _tv;

    public TVOnCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute() =>
        _tv.On();

    public void Undo() =>
        _tv.Off();
}