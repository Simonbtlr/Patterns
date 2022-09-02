using System;
using System.Collections.Generic;

namespace Patterns.StructuralPatterns.Composite.Example;

public class Directory : Component
{
    private List<Component> _components = new();

    public Directory(string name)
        : base(name)
    {
    }

    public override void Add(Component component) =>
        _components.Add(component);

    public override void Remove(Component component) =>
        _components.Remove(component);

    public override void Print()
    {
        Console.WriteLine($"Узел {Name}");
        Console.WriteLine("Подузлы:");

        foreach (var component in _components)
            component.Print();
    }
}