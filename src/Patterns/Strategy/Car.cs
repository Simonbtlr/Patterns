namespace Patterns.Strategy;

public class Car
{
    public IMovable Movable { private get; set; }
    
    protected int Passengers;
    protected string Model;

    public Car(
        int passengers, 
        string model, 
        IMovable movable)
    {
        Passengers = passengers;
        Model = model;
        Movable = movable;
    }

    public void Move()
    {
        Movable.Move();
    }
}