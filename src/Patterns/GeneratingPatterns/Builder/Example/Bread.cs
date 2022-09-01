using System.Text;

namespace Patterns.GeneratingPatterns.Builder.Example;

public class Bread
{
    public Flour Flour { get; set; }
    public Salt Salt { get; set; }
    public Additives Additives { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        if (Flour is not null)
            sb.Append($"{Flour.Sort}\n");

        if (Salt is not null)
            sb.Append("Соль\n");

        if (Additives is not null)
            sb.Append($"Добавки: {Additives.Name}\n");

        return sb.ToString();
    }
}