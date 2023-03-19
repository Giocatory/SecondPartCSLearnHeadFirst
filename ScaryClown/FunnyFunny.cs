namespace ScaryClown;

public abstract class FunnyFunny : IClown
{
    public string FunnyThingIHave => FunnyThingHave;

    private string FunnyThingHave { get; }

    public FunnyFunny(string funnyThingHave)
    {
        FunnyThingHave = funnyThingHave;
    }
    public void Honk()
    {
        Console.WriteLine($"Hi kids! I have a {FunnyThingIHave}");
    }
}