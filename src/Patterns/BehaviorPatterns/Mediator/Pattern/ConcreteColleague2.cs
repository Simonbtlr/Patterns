namespace Patterns.BehaviorPatterns.Mediator.Pattern;

/// <summary>
/// Конкретный класс коллеги, котоорый общается с другими
/// через объект Mediator.
/// </summary>
public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator) : base(mediator)
    {
    }

    public void Send(string message) =>
        Mediator.Send(message, this);

    public void Notify(string message)
    {
    }
}