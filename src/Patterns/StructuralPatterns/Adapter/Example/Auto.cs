using System;

namespace Patterns.StructuralPatterns.Adapter.Example;

public class Auto : ITransport
{
    public void Drive() =>
        Console.WriteLine("Машина едет по дороге");
}