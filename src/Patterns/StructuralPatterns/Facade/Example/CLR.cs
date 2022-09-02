using System;

namespace Patterns.StructuralPatterns.Facade.Example;

public class CLR
{
    public void Execute() =>
        Console.WriteLine("Выполенение приложения");

    public void Finish() =>
        Console.WriteLine("Завершение работы приложения");
}