namespace Patterns.StructuralPatterns.Proxy.Pattern;

/// <summary>
/// Использует объект Proxy для доступа к объекту RealSubject
/// </summary>
public class Client
{
    public void Main()
    {
        var subject = new Proxy();
        subject.Request();
    }
}