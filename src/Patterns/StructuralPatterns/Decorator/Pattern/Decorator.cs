namespace Patterns.StructuralPatterns.Decorator.Pattern;

/// <summary>
/// Собственно декоратор, реализуется в виде абстрактного класса
/// и имеет тот же базовый класс, что и декорируемые объекты.
/// Поэтому базовый класс Component должен быть по возможности легким
/// и определять только базовый интерфейс.
///
/// Класс декоратора также хранит ссылку на декорируемый объект
/// в виде объекта базового класса Component и реализует связь
/// с базовым классом как через наследование, так и через отношение
/// агрегации.
/// </summary>
public class Decorator : Component
{
    protected Component Component;

    public void SetComponent(Component component) =>
        Component = component;

    public override void Operation() =>
        Component?.Operation();
}