namespace Patterns.State.Pattern;

public class Client
{
    public void Main()
    {
        var context = new Context(new StateA());
        context.Request();
        context.Request();
    }
}