namespace Patterns.BehaviorPatterns.Command.Example;

public class Client
{
    public void Main()
    {
        var pult = new Pult();
        var tv = new TV();

        pult.SetCommand(new TVOnCommand(tv));
        pult.PressButton();
        pult.PressUndo();
    }
}