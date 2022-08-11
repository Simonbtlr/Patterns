namespace Patterns.Mediator.Example;

public class TesterColleague : Colleague
{
    public TesterColleague(Mediator mediator) : base(mediator) { }

    public override void Notify(string message) =>
        Console.WriteLine($"Сообщение тестеру: {message}");
}