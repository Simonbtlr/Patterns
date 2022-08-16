namespace Patterns.Generating_patterns.Singleton.Pattern;

public class GenericLazySingleton
{
    public string Name { get; private set; }

    private static readonly Lazy<GenericLazySingleton> _lazy = new();

    private GenericLazySingleton()
    {
        Name = Guid.NewGuid().ToString();
    }

    public static GenericLazySingleton GetInstance() =>
        _lazy.Value;
}