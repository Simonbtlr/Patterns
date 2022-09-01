using System;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Movements;

public class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Бежим");
    }
}