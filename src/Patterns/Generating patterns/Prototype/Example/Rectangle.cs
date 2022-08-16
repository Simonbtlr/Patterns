namespace Patterns.Generating_patterns.Prototype.Example;

public class Rectangle : IFigure
{
    private int _width;
    private int _height;

    public Rectangle(
        int width,
        int height)
    {
        _width = width;
        _height = height;
    }

    public IFigure Clone() =>
        new Rectangle(_width, _height);

    public void GetInfo() =>
        Console.WriteLine($"Прямоуголник длинной {_height} и шириной {_width}.");
}