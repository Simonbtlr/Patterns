namespace Patterns.GeneratingPatterns.AbstractFactory.Example.Factory;

public abstract class HeroFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}