namespace Patterns.GeneratingPatterns.Prototype.Example;

public interface IFigure
{
    IFigure Clone();
    void GetInfo();
}