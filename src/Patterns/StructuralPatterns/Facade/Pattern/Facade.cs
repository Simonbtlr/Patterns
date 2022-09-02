namespace Patterns.StructuralPatterns.Facade.Pattern;

public class Facade
{
    private readonly SubsystemA _subsystemA;
    private readonly SubsystemB _subsystemB;
    private readonly SubsystemC _subsystemC;

    public Facade(
        SubsystemA subsystemA,
        SubsystemB subsystemB,
        SubsystemC subsystemC)
    {
        _subsystemA = subsystemA;
        _subsystemB = subsystemB;
        _subsystemC = subsystemC;
    }

    public void Operation1()
    {
        _subsystemA.A1();
        _subsystemB.B1();
        _subsystemC.C1();
    }

    public void Operation2()
    {
        _subsystemB.B1();
        _subsystemC.C1();
    }
}