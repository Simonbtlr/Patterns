namespace Patterns.Mediator;

public abstract class Colleague
{
    protected Mediator Mediator;

    public Colleague(Mediator mediator)
    {
        Mediator = mediator;
    }

    public virtual void Send(string message)
    {
        Mediator.Send(
            msg: message, 
            colleague: this);
    }

    public abstract void Notify(string message);
}