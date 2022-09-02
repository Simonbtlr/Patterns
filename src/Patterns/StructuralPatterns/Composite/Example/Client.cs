namespace Patterns.StructuralPatterns.Composite.Example;

public class Client
{
    public void Main()
    {
        var fileSystem = new Directory("Файловая система");
        var diskC = new Directory("Диск C");
        var pngFile = new File("12345.png");
        var docxFile = new File("Document.docx");

        diskC.Add(pngFile);
        diskC.Add(docxFile);

        fileSystem.Add(diskC);
        fileSystem.Print();

        diskC.Remove(pngFile);

        var docsFolder = new Directory("Мои документы");
        var txtFile = new File("readme.txt");
        var csFile = new File("Program.cs");

        docsFolder.Add(txtFile);
        docsFolder.Add(csFile);

        diskC.Add(docsFolder);
        fileSystem.Print();
    }
}