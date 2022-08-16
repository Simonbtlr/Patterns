namespace Patterns.GeneratingPatterns.Singleton.Pattern;

public class Singleton
{
    private static Singleton? _instance;

    public static Singleton GetInstance() =>
        _instance ??= new Singleton();
}