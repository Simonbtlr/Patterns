namespace Patterns.StructuralPatterns.Adapter.Pattern;

/// <summary>
/// Собственно адаптер, который позволяет работать
/// с объектами Adaptee как с объектами Target.
/// </summary>
public class Adapter : Target
{
    private Adaptee _adaptee = new();

    public override void Request()
    {
        _adaptee.SpecificRequest();
    }
}