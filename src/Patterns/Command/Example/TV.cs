namespace Patterns.Command.Example;

public class TV
{
    public void On() =>
        Console.WriteLine("Телевизор включен!");

    public void Off() =>
        Console.WriteLine("Телевизор выключен...");
}