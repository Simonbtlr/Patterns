using Patterns.Strategy;

namespace Patterns.UnitTests.Common.TestFactories;

public static class CarTestFactory
{
    public static Car MakeDefaultCar(
        int passangers = 5,
        string model = "Lada",
        IMovable? movable = null)
    {
        movable ??= new PetrolMove();
        
        return new Car(
            passengers: passangers,
            model: model,
            movable: movable);
    }
}