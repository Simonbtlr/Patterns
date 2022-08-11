namespace Patterns.Strategy.Example;

public class PetrolMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение на бензине");
    }
}