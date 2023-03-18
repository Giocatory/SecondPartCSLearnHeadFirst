using ExperimentWithInterface;
using System.Threading;

IPrintInfo[] ObjectsPrint = {
                                new Bot("One"),
                                new Bot("Two"),
                                new Bot("Three"),
                                new Bot(),
};

foreach (var obj in ObjectsPrint)
{
    Console.WriteLine(obj.Print);
}
/*
Bot object: id(1) - name(One)
Bot object: id(2) - name(Two)
Bot object: id(3) - name(Three)
Bot object: id(4) - name(no-name)
*/