namespace ScaryClown;

public class ScaryScary : FunnyFunny, IScaryClown
{
    private readonly int _scaryThingCount;
    public string FunnyThingIHave { get; }

    public ScaryScary(int scaryCount, string funnyThingIHave):
        base(funnyThingIHave)
    {
        _scaryThingCount = scaryCount;
        FunnyThingIHave = funnyThingIHave;
    }

    public string ScaryThingIHave => $"{_scaryThingCount} spiders.";

    public void Honk()
    {

    }

    public string ScaryThingHave { get; } = "";
    public void ScareLittleChildren()
    {
        Console.WriteLine($"Boo! Gotcha! Look at my {FunnyThingIHave}!");
    }
}