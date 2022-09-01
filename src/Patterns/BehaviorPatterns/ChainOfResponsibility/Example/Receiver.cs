namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Example;

public class Receiver
{
    public bool BankTransfer { get; }
    public bool MoneyTransfer { get; }
    public bool PayPalTransfer { get; }

    public Receiver(
        bool bankTransfer,
        bool moneyTransfer,
        bool payPalTransfer)
    {
        BankTransfer = bankTransfer;
        MoneyTransfer = moneyTransfer;
        PayPalTransfer = payPalTransfer;
    }
}