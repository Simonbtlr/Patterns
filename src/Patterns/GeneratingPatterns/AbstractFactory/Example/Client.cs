using Patterns.GeneratingPatterns.AbstractFactory.Example.Factory;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public class Client
{
    public void Main()
    {
        var elf = new Hero(new ElfFactory());
        elf.Hit();
        elf.Run();

        var voin = new Hero(new VoinFactory());
        voin.Hit();
        voin.Run();
    }
}