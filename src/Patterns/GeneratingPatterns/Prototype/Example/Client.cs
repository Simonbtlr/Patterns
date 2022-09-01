namespace Patterns.GeneratingPatterns.Prototype.Example;

public class Client
{
    public void Main()
    {
        var figure = new Circle(
            radius: 30,
            x: 50,
            y: 60);

        var clonedFigure = figure.DeepCopy() as Circle;

        figure.Point.X = 100;
        figure.GetInfo();

        clonedFigure?.GetInfo();
    }
}