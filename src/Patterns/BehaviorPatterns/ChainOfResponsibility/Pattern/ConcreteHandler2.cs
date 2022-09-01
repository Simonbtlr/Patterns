using System;

namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Pattern;

/// <summary>
/// Конкретный обработчик, который реализирует функционал
/// для обработки запроса. При невозможности обработки
/// и наличия ссылки на следующий обработчик, передает
/// запрос следующему обработчику.
///
/// В данном случае для простоты примера в качестве параметра
/// передается некторое число, сначала обработчик обрабатывает
/// запрос и, если передано соответствующее число, завершает
/// его обработку. Иначе передает запрос на обработку следующем
/// в цепи обработчику при его наличии.
/// </summary>
public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int condition)
    {
        if (condition == 2)
            Console.WriteLine(condition);
        else
            Successor?.HandleRequest(condition);
    }
}