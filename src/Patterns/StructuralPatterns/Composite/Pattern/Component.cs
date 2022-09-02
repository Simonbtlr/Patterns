namespace Patterns.StructuralPatterns.Composite.Pattern;

/// <summary>
/// Определяет интерфейс для всех компонентов
/// в древовидной структуре
/// </summary>
public abstract class Component
{
    protected string Name;

    public Component(string name)
    {
        Name = name;
    }

    public abstract void Display();
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
}