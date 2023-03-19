using ScaryClown;

IClown fingerTheClown = new ScaryScary(14, "big red nose");
fingerTheClown.Honk();
if (fingerTheClown is IScaryClown iScaryClownReference)
{
    iScaryClownReference.ScareLittleChildren();
}

// Boo! Gotcha! Look at my big red nose!

Console.WriteLine();
IClown.CarCapacity = 18;
Console.WriteLine(IClown.ClownCarDescription()); // A clown car with 10 clowns.