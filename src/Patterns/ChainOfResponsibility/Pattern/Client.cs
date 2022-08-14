namespace Patterns.ChainOfResponsibility.Pattern;

/// <summary>
/// Отправляет запрос объекту Handler.
/// </summary>
public class Client
{
    public void Main()
    {
        var h1 = new ConcreteHandler1();
        var h2 = new ConcreteHandler2();

        h1.Successor = h2;
        h1.HandleRequest(2);
    }
}