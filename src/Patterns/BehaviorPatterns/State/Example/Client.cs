using Patterns.BehaviorPatterns.State.Example.States;

namespace Patterns.BehaviorPatterns.State.Example;

public class Client
{
    public void Main()
    {
        var water = new Water(new LiquidWaterState());
        water.Heat();
        water.Frost();
        water.Frost();
    }
}