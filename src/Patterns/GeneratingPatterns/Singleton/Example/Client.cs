using System;
using System.Threading;

namespace Patterns.GeneratingPatterns.Singleton.Example;

public class Client
{
    public void Main()
    {
        new Thread(() =>
        {
            var comp2 = new Computer();
            comp2.OS = OS.GetInstance("Windows 10");

            Console.WriteLine(comp2.OS?.Name);
        }).Start();

        var comp = new Computer();
        comp.OS = OS.GetInstance("Windows 8.1");

        Console.WriteLine(comp.OS?.Name);
    }
}