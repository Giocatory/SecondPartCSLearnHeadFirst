namespace ComicsCollection;

public class Comic
{
    public string Name { get; set; } = "";
    public int Issue { get; set; }
    public static Dictionary<int, decimal> Price = new();

    public override string ToString() => $"{Name} (Issue #{Issue})";

    public static readonly IEnumerable<Comic> Catalog = new List<Comic>()
    {
        new Comic {Name = "Johnny America vs the Pinko", Issue = 6},
        new Comic {Name = "Rock and Roll", Issue = 19},
        new Comic {Name = "Black Monday", Issue = 74},
        new Comic {Name = "The Death of the Object", Issue = 97}
    };

    public static readonly IReadOnlyDictionary<int, decimal> Prices = new Dictionary<int, decimal>
    {
        {6, 3600M},
        {19, 500M},
        {74, 75M},
        {97, 32.25M},
    };
}