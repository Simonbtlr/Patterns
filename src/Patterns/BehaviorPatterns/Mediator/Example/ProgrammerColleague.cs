using System;

namespace Patterns.BehaviorPatterns.Mediator.Example;

public class ProgrammerColleague : Colleague
{
    public ProgrammerColleague(Mediator mediator) : base(mediator)
    {
    }

    public override void Notify(string message) =>
        Console.WriteLine($"Сообщение программисту: {message}");
}