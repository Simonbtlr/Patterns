namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public class FlyMovement : Movement
{
    public override void Move()
    {
        Console.WriteLine("Летим");
    }
}