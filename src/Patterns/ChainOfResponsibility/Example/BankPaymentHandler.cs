namespace Patterns.ChainOfResponsibility.Example;

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