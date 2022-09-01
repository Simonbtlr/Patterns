namespace Patterns.GeneratingPatterns.Builder.Pattern;

public class Client
{
    public void Main()
    {
        var builder = new ConcreteBuilder();
        var director = new Director(builder);
        director.Construct();

        var product = builder.GetResult();
    }
}