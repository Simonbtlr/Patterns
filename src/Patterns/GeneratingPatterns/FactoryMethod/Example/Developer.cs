namespace Patterns.GeneratingPatterns.FactoryMethod.Example;

public abstract class Developer
{
    public string Name { get; set; }

    public Developer(string name)
    {
        Name = name;
    }

    public abstract House Create();
}