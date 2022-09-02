namespace Patterns.StructuralPatterns.Adapter.Example;

public class Client
{
    public void Main()
    {
        var driver = new Driver();
        var auto = new Auto();

        driver.Travel(auto);

        var camel = new Camel();
        var camelTransport = new CamelToTransportAdapter(camel);

        driver.Travel(camelTransport);
    }
}