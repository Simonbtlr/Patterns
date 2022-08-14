namespace Patterns.ChainOfResponsibility.Example;

public class MoneyPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.MoneyTransfer)
            Console.WriteLine("Выполнен перевод через систему денежных переводов");
        else
            Successor.Handle(receiver);
    }
}