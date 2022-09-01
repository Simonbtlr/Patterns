namespace Patterns.BehaviorPatterns.Command.Pattern;

/// <summary>
/// Интерфейс, представляюющий команду. Обычно определяет
/// метод Execute() для выполнения, а также нередко включает
/// метод Undo(), реализация которого должна заключаться
/// в отмене действия команды.
/// </summary>
public abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}