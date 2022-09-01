namespace Patterns.BehaviorPatterns.Strategy.Example;

public class Client
{
    public void Main()
    {
        var auto = new Car(
            passengers: 4,
            model: "Volvo",
            movable: new PetrolMove());

        auto.Move();
        auto.Movable = new ElectricMove();
        auto.Move();
    }
}