namespace Patterns.StructuralPatterns.Facade.Example;

public class Programmer
{
    public void CreateApplication(VisualStudioFacade facade)
    {
        facade.Start();
        facade.Stop();
    }
}