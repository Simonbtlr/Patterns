namespace Patterns.State.Example;

public interface IWaterState
{
    void Heat(Water water);
    void Frost(Water water);
}