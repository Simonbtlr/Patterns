namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Pattern;

/// <summary>
/// Интерфейс для обработки запроса. Также может определять
/// ссылку на следующий обработчик запроса. 
/// </summary>
public abstract class Handler
{
    public Handler Successor { get; set; }
    public abstract void HandleRequest(int condition);
}