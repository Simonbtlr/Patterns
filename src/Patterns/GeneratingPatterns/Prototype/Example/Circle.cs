using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns.GeneratingPatterns.Prototype.Example;

[Serializable]
public class Circle : IFigure
{
    public Point Point { get; set; }

    private int _radius;

    public Circle(
        int radius, int x, int y)
    {
        _radius = radius;
        Point = new Point
        {
            X = x,
            Y = y
        };
    }

    public IFigure Clone() =>
        MemberwiseClone() as IFigure;

    public object DeepCopy()
    {
        using var tempStream = new MemoryStream();

        var binaryFormatter = new BinaryFormatter(
            selector: null,
            context: new StreamingContext(StreamingContextStates.Clone));

        binaryFormatter.Serialize(
            serializationStream: tempStream,
            graph: this);
        tempStream.Seek(
            offset: 0,
            loc: SeekOrigin.Begin);

        var figure = binaryFormatter.Deserialize(tempStream);

        return figure;
    }

    public void GetInfo() =>
        Console.WriteLine($"Круг радиусом {_radius}.");
}