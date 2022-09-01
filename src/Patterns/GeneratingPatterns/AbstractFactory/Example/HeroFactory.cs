namespace Patterns.GeneratingPatterns.AbstractFactory.Example;

public abstract class HeroFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}