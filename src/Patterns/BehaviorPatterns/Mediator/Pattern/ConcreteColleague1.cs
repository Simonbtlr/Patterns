namespace Patterns.BehaviorPatterns.Mediator.Pattern;

/// <summary>
/// Конкретный класс коллеги, котоорый общается с другими
/// через объект Mediator.
/// </summary>
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message) =>
        Mediator.Send(message, this);

    public void Notify(string message)
    {
    }
}