using System;

namespace Patterns.GeneratingPatterns.Singleton.Pattern;

public class LazySingleton
{
    public static string Text = "Hello";
    public string Date { get; private set; }

    private LazySingleton()
    {
        Console.WriteLine($"Singletone ctor {DateTime.Now.TimeOfDay}");
        Date = DateTime.Now.TimeOfDay.ToString();
    }

    public static LazySingleton GetInstance()
    {
        Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");

        return Nested._instance;
    }

    private class Nested
    {
        internal static readonly LazySingleton _instance = new();

        static Nested()
        {
        }
    }
}