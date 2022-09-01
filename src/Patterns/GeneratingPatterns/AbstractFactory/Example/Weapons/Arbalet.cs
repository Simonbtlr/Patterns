using System;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Weapons;

public class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Стреляем из арбалета");
    }
}