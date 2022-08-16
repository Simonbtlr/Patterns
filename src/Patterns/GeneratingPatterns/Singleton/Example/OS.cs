namespace Patterns.GeneratingPatterns.Singleton.Example;

public class OS
{
    public string Name { get; private set; }

    private static readonly object SyncRoot = new();
    private static OS? _instance;

    protected OS(string name)
    {
        Name = name;
    }

    public static OS? GetInstance(string name)
    {
        if (_instance is not null)
            return _instance;

        lock (SyncRoot)
            _instance = new OS(name);

        return _instance;
    }
}