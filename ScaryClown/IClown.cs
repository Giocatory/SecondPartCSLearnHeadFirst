namespace ScaryClown;

public interface IClown
{
    string FunnyThingIHave { get; }
    void Honk();

    protected static Random _random = new();
    private static int _carCapacity = 12;
    
    public static int CarCapacity
    {
        get => _carCapacity;
        set
        {
            if (value > 10)
            {
                _carCapacity = value;
            }
            else
            {
                Console.Error.WriteLine($"Warning: Car capacity {value} is too small!");
            }
        }
    }

    public static string ClownCarDescription()
    {
        return $"A clown car with {_random.Next(CarCapacity / 2, CarCapacity)} clowns.";
    }
}