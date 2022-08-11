namespace Patterns.Strategy;

public class PetrolMove : IMovable
{
    public void Move()
    {
        Console.WriteLine("Перемещение на бензине");
    }
}