using System;

namespace Patterns.GeneratingPatterns.FactoryMethod.Example;

public class PanelHouse : House
{
    public PanelHouse()
    {
        Console.WriteLine("Панельный дом построен");
    }
}