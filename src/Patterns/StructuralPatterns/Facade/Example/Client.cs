namespace Patterns.StructuralPatterns.Facade.Example;

public class Client
{
    public void Main()
    {
        var textEditor = new TextEditor();
        var compiller = new Compiller();
        var clr = new CLR();
        var programmer = new Programmer();
        var ide = new VisualStudioFacade(
            textEditor,
            compiller,
            clr);

        programmer.CreateApplication(ide);
    }
}