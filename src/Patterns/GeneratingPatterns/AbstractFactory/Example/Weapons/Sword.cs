using System;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Weapons;

public class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Бьем мечом");
    }
}