namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Бьем мечом");
    }
}