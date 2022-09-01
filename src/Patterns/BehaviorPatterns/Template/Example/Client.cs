namespace Patterns.BehaviorPatterns.Template.Example;

public class Client
{
    public void Main()
    {
        var school = new School();
        var university = new University();

        school.Learn();
        university.Learn();
    }
}