using System;

namespace Patterns.StructuralPatterns.Composite.Pattern;

/// <summary>
/// Представляет отдельный компонент,
/// который не может содержать другие компоненты
/// </summary>
public class Leaf : Component
{
    public Leaf(string name)
        : base(name)
    {
    }

    public override void Display() =>
        Console.WriteLine(Name);

    public override void Add(Component component) =>
        throw new NotImplementedException();

    public override void Remove(Component component) =>
        throw new NotImplementedException();
}