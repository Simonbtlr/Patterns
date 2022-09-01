namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public class RunMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Бежим");
    }
}