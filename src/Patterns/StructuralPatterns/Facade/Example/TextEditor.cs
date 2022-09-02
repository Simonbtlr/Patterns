using System;

namespace Patterns.StructuralPatterns.Facade.Example;

public class TextEditor
{
    public void CreateCode() =>
        Console.WriteLine("Написание кода");

    public void SaveCode() =>
        Console.WriteLine("Сохранение кода");
}