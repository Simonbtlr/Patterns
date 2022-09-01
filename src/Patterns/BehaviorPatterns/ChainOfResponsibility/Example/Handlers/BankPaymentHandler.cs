using System;

namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Example.Handlers;

public class BankPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.BankTransfer)
            Console.WriteLine("Выполнен банковский перевод");
        else
            Successor.Handle(receiver);
    }
}