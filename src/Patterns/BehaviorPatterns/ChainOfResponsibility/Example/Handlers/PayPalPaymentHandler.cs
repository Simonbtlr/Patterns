using System;

namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Example.Handlers;

public class PayPalPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.PayPalTransfer)
            Console.WriteLine("Выполен перевод через PayPal");
        else
            Successor.Handle(receiver);
    }
}