namespace Patterns.State.Example;

public class GasWaterState : IWaterState
{
    public void Heat(Water water) =>
        Console.WriteLine("Повышаем температуру водняного пара");

    public void Frost(Water water)
    {
        Console.WriteLine("Превращаем водяной пар в жидкость");

        water.State = new LiquidWaterState();
    }
}