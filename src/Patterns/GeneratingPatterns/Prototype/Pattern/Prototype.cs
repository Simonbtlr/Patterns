namespace Patterns.GeneratingPatterns.Prototype.Pattern;

/// <summary>
/// Интерфейс для клонирования самого себя,
/// который, как правило, предтсваляет метод Clone().
/// </summary>
public abstract class Prototype
{
    public int Id { get; private set; }

    public Prototype(int id)
    {
        Id = id;
    }

    public abstract Prototype Clone();
}