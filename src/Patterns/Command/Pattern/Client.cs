namespace Patterns.Command.Pattern;

/// <summary>
/// Клиент создает команду и устанавливает ее получателя
/// с помощью метода SetCommand()
/// </summary>
public class Client
{
    void Main()
    {
        var invoker = new Invoker();
        var receiver = new Receiver();
        var command = new ConcreteCommand(receiver);

        invoker.SetCommand(command);
        invoker.Run();
    }
}