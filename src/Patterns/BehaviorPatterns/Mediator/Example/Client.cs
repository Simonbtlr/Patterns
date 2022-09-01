namespace Patterns.BehaviorPatterns.Mediator.Example;

public class Client
{
    public void Main()
    {
        var mediator = new ManagerMediator();
        var customer = new CustomerColleague(mediator);
        var programmer = new ProgrammerColleague(mediator);
        var tester = new TesterColleague(mediator);

        mediator.Customer = customer;
        mediator.Programmer = programmer;
        mediator.Tester = tester;

        customer.Send("Есть заказ, надо сделать программу");
        programmer.Send("Программа готова, надо протестировать");
        tester.Send("Программа протестирована и готова к продаже");
    }
}