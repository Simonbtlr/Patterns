namespace Patterns.StructuralPatterns.Adapter.Example;

public class Driver
{
    public void Travel(ITransport transport) =>
        transport.Drive();
}