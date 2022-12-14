namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Example;

public abstract class PaymentHandler
{
    public PaymentHandler Successor { get; set; }
    public abstract void Handle(Receiver receiver);
}