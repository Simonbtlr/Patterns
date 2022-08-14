using Patterns.ChainOfResponsibility.Example;

namespace Patterns.UnitTests;

public class ChainOfResponsibilityTests
{
    [Fact]
    public void Bank_can_handle_bank_transfer()
    {
        // Arrange
        var receiver = new Receiver(
            bankTransfer: true,
            moneyTransfer: false,
            payPalTransfer: false);

        var bankPaymentHandler = new BankPaymentHandler();

        // Act
        var result = () => bankPaymentHandler.Handle(receiver);

        // Assert
        result
            .Should()
            .NotThrow();
    }

    [Fact]
    public void Bank_can_resend_paypal_transfer()
    {
        // Arrange
        var receiver = new Receiver(
            bankTransfer: false,
            moneyTransfer: false,
            payPalTransfer: true);

        var bankPaymentHandler = new BankPaymentHandler();
        var paypalPaymentHandler = new PayPalPaymentHandler();

        bankPaymentHandler.Successor = paypalPaymentHandler;

        // Act
        var result = () => bankPaymentHandler.Handle(receiver);

        // Assert
        result
            .Should()
            .NotThrow();
    }

    [Fact]
    public void Bank_can_resend_money_transfer()
    {
        // Arrange
        var receiver = new Receiver(
            bankTransfer: false,
            moneyTransfer: true,
            payPalTransfer: false);

        var bankPaymentHandler = new BankPaymentHandler();
        var moneyPaymentHandler = new MoneyPaymentHandler();

        bankPaymentHandler.Successor = moneyPaymentHandler;

        // Act
        var result = () => bankPaymentHandler.Handle(receiver);

        // Assert
        result
            .Should()
            .NotThrow();
    }

    [Fact]
    public void Bank_can_resend_money_transfer_with_paypal()
    {
        // Arrange
        var receiver = new Receiver(
            bankTransfer: false,
            moneyTransfer: true,
            payPalTransfer: false);

        var bankPaymentHandler = new BankPaymentHandler();
        var paypalPaymentHandler = new PayPalPaymentHandler();
        var moneyPaymentHandler = new MoneyPaymentHandler();

        bankPaymentHandler.Successor = paypalPaymentHandler;
        paypalPaymentHandler.Successor = moneyPaymentHandler;

        // Act
        var result = () => bankPaymentHandler.Handle(receiver);

        // Assert
        result
            .Should()
            .NotThrow();
    }
}