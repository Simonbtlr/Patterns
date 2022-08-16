namespace Patterns.Generating_patterns.Prototype.Example;

public interface IFigure
{
    IFigure Clone();
    void GetInfo();
}