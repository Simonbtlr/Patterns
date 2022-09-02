namespace Patterns.StructuralPatterns.Adapter.Pattern;

/// <summary>
/// Использует объекты Target для реализации своих задач
/// </summary>
public class Client
{
    public void Request(Target target)
    {
        target.Request();
    }
}