using System;

namespace Patterns.GeneratingPatterns.FactoryMethod.Example;

public class WoodHouse : House
{
    public WoodHouse()
    {
        Console.WriteLine("Деревянный дом построен");
    }
}