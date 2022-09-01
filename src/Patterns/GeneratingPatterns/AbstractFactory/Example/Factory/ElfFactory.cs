using Patterns.GeneratingPatterns.AbstractFactory.Example.Movements;
using Patterns.GeneratingPatterns.AbstractFactory.Example.Weapons;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Factory;

public class ElfFactory : HeroFactory
{
    public override Movement CreateMovement() =>
        new FlyMovement();

    public override Weapon CreateWeapon() =>
        new Arbalet();
}