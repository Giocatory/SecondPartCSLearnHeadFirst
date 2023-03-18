﻿using ExperimentWithInterface;
using System.Threading;

IPrintInfo[] ObjectsPrint = {
                                new Bot("One"),
                                new Bot("Two"),
                                new Bot("Three"),
};

foreach (var obj in ObjectsPrint)
{
    Console.WriteLine(obj.ToString(obj));
}
/*
Bot object: id(1) - name(One)
Bot object: id(2) - name(Two)
Bot object: id(3) - name(Three)
*/