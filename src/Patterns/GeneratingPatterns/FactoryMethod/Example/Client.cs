namespace Patterns.GeneratingPatterns.FactoryMethod.Example;

public class Client
{
    public void Main()
    {
        var dev = new PanelDeveloper("ООО КирпичСтрой") as Developer;
        var house = dev.Create();

        dev = new WoodDeveloper("Частный застройщик");
        var house2 = dev.Create();
    }
}