namespace Patterns.StructuralPatterns.Adapter.Example;

public class CamelToTransportAdapter : ITransport
{
    private Camel _camel;

    public CamelToTransportAdapter(Camel camel)
    {
        _camel = camel;
    }

    public void Drive()
    {
        _camel.Move();
    }
}