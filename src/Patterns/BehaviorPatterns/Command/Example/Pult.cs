namespace Patterns.BehaviorPatterns.Command.Example;

public class Pult
{
    private ICommand _command;

    public void SetCommand(ICommand command) =>
        _command = command;

    public void PressButton() =>
        _command.Execute();

    public void PressUndo() =>
        _command.Undo();
}