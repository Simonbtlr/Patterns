using System;

namespace Patterns.StructuralPatterns.Adapter.Example;

public class Camel : IAnimal
{
    public void Move() =>
        Console.WriteLine("Верблюд идет по пескам пустыни");
}