namespace Patterns.GeneratingPatterns.FactoryMethod.Example;

public class PanelDeveloper : Developer
{
    public PanelDeveloper(string name) : base(name)
    {
    }

    public override House Create() =>
        new PanelHouse();
}