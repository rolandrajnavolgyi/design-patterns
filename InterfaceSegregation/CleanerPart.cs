using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation;

internal class CleanerPart : ICleaner
{
    public void Clean(Fruit fruit)
    {
        Console.WriteLine($"{fruit} has been cleaned");
    }
}
