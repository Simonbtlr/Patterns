namespace Patterns.StructuralPatterns.Facade.Pattern;

/// <summary>
/// Взаимодействует с компонентами подсистемы
/// </summary>
public class Client
{
    public void Main()
    {
        var facade = new Facade(
            new SubsystemA(),
            new SubsystemB(),
            new SubsystemC());

        facade.Operation1();
        facade.Operation2();
    }
}