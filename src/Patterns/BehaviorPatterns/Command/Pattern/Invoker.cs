namespace Patterns.BehaviorPatterns.Command.Pattern;

/// <summary>
/// Инициатор команды - вызывает команду для выполнения
/// определенного запроса.
/// </summary>
public class Invoker
{
    private Command _command;

    public void SetCommand(Command command) =>
        _command = command;

    public void Run() =>
        _command.Execute();

    public void Cancel() =>
        _command.Undo();
}