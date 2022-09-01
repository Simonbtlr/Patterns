using System;

namespace Patterns.BehaviorPatterns.Strategy.Example;

public class ElectricMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение на электричестве");
    }
}