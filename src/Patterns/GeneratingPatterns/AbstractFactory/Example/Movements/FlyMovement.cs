using System;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Movements;

public class FlyMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Летим");
    }
}