namespace Patterns.StructuralPatterns.Proxy.Pattern;

/// <summary>
/// Заместитель реального объекта. Хранит ссылку на реальный объект,
/// контролирует к нему доступ, может управлять его созданием и удалением.
/// При необходимости Proxy переадресует запросы объекту RealSubject
/// </summary>
public class Proxy : Subject
{
    private RealSubject _realSubject;

    public override void Request()
    {
        _realSubject ??= new RealSubject();
        _realSubject.Request();
    }
}