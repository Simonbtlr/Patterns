using System;
using System.Collections.Generic;

namespace Patterns.StructuralPatterns.Composite.Pattern;

/// <summary>
/// Представляет компонент, который может содержать другие
/// компоненты и реализует механизм для их добавления и удаления
/// </summary>
public class Composite : Component
{
    private readonly List<Component> _components = new();

    public Composite(string name)
        : base(name)
    {
    }

    public override void Display()
    {
        Console.WriteLine(Name);

        foreach (var component in _components)
            component.Display();
    }

    public override void Add(Component component) =>
        _components.Add(component);

    public override void Remove(Component component) =>
        component.Remove(component);
}