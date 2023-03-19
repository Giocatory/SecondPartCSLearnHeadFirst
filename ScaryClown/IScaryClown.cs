namespace ScaryClown;

public interface IScaryClown : IClown
{
    string ScaryThingHave { get; }
    void ScareLittleChildren();

    void ScareAdults()
    {
        Console.WriteLine($@"I'm an ancient evil that will haunt your dreams. Behold my terrifying" + 
                          $@"necklace with {_random.Next(4, 10)} of my last victim's fingers." + 
                          $@"\n\nOh, also, before I forget...");
        ScareLittleChildren();
    }
}