namespace Patterns.Generating_patterns.Singleton.Pattern;

public class Singleton
{
    private static Singleton? _instance;

    public static Singleton GetInstance() =>
        _instance ??= new Singleton();
}