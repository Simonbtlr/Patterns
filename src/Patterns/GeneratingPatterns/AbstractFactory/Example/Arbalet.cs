namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Стреляем из арбалета");
    }
}