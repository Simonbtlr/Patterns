namespace Patterns.GeneratingPatterns.Singleton.Pattern;

public class ThreadSafeSingleton
{
    private static readonly ThreadSafeSingleton _instance = new ThreadSafeSingleton();

    public string Date { get; private set; }

    public ThreadSafeSingleton()
    {
        Date = DateTime.Now.TimeOfDay.ToString();
    }

    public static ThreadSafeSingleton GetInstance() =>
        _instance;
}