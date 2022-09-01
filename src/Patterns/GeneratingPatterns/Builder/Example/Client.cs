using System;

namespace Patterns.GeneratingPatterns.Builder.Example;

public class Client
{
    public void Main()
    {
        var baker = new Baker();
        var builder = new RyeBreadBuilder() as BreadBuilder;
        var ryeBread = baker.Bake(builder);

        Console.WriteLine(ryeBread.ToString());

        builder = new WheatBreadBuilder();
        var wheatBread = baker.Bake(builder);

        Console.WriteLine(wheatBread.ToString());
    }
}