namespace Patterns.BehaviorPatterns.Command.Example;

public interface ICommand
{
    void Execute();
    void Undo();
}