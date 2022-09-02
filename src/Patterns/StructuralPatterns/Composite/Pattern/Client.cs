namespace Patterns.StructuralPatterns.Composite.Pattern;

/// <summary>
/// Клиент, который использует компоненты
/// </summary>
public class Client
{
    public void Main()
    {
        var root = new Composite("Root");
        var leaf = new Leaf("Leaf");
        var subtree = new Composite("Subtree");

        root.Add(leaf);
        root.Add(subtree);
        root.Display();
    }
}