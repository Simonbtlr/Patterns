namespace Patterns.StructuralPatterns.Proxy.Pattern;

/// <summary>
/// Определяет общий интерфейс для Proxy и RealSubject.
/// Поэтому Proxy может использоваться вместо RealSubject
/// </summary>
public abstract class Subject
{
    public abstract void Request();
}