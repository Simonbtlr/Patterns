using System;

namespace Patterns.BehaviorPatterns.State.Example.States;

public class SolidWaterState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Превращаем лед в жидкость");

        water.State = new LiquidWaterState();
    }

    public void Frost(Water water) =>
        Console.WriteLine("Продолжаем заморозку льда");
}