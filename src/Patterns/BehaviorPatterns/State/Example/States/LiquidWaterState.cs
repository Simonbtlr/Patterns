using System;

namespace Patterns.BehaviorPatterns.State.Example.States;

public class LiquidWaterState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Превращаем жидкость в пар");

        water.State = new GasWaterState();
    }

    public void Frost(Water water)
    {
        Console.WriteLine("Превращаем жидкость в лед");

        water.State = new SolidWaterState();
    }
}