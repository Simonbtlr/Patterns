namespace Patterns.StructuralPatterns.Decorator.Pattern;

/// <summary>
/// Представляют дополнительные функциональности,
/// которыми должен быть расширен объект ConcreteComponent.
/// </summary>
public class ConcreteDecoratorB : Decorator
{
    public override void Operation() =>
        base.Operation();
}