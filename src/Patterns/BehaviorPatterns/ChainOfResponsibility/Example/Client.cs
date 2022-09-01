using Patterns.BehaviorPatterns.ChainOfResponsibility.Example.Handlers;

namespace Patterns.BehaviorPatterns.ChainOfResponsibility.Example;

public class Client
{
    public void Main()
    {
        var receiver = new Receiver(
            bankTransfer: false,
            moneyTransfer: true,
            payPalTransfer: true);

        var bankPaymentHandler = new BankPaymentHandler();
        var moneyPaymentHandler = new MoneyPaymentHandler();
        var paypalPaymentHandler = new PayPalPaymentHandler();

        bankPaymentHandler.Successor = paypalPaymentHandler;
        paypalPaymentHandler.Successor = moneyPaymentHandler;

        bankPaymentHandler.Handle(receiver);
    }
}