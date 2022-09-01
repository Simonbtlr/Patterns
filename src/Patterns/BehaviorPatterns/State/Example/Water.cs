namespace Patterns.BehaviorPatterns.State.Example;

public class Water
{
    public IWaterState State { get; set; }

    public Water(IWaterState state)
    {
        State = state;
    }

    public void Heat()
    {
        State.Heat(this);
    }

    public void Frost()
    {
        State.Frost(this);
    }
}