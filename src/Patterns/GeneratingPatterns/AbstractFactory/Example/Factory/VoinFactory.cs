using Patterns.GeneratingPatterns.AbstractFactory.Example.Movements;
using Patterns.GeneratingPatterns.AbstractFactory.Example.Weapons;

namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Factory;

public class VoinFactory : HeroFactory
{
    public override Movement CreateMovement() =>
        new RunMovement();

    public override Weapon CreateWeapon() =>
        new Sword();
}