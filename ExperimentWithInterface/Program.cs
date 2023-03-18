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
    var dt = (Bot)obj;
    dt.Description = "simple chat bot";
   
    Console.WriteLine($"{obj.Print};\t{dt.Description}");
}
/*
Bot object: id(1) - name(One);          simple chat bot
Bot object: id(2) - name(Two);          simple chat bot
Bot object: id(3) - name(Three);        simple chat bot
Bot object: id(4) - name(no-name);      simple chat bot
*/
