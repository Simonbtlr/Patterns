namespace Patterns.BehaviorPatterns.Mediator.Example;

public abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}