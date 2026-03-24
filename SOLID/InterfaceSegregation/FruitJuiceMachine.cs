using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace InterfaceSegregation;

internal class FruitJuiceMachine(ICleaner cleaner, ISqueezer squeezer) : IJuiceMachine
{
    public void Clean(Fruit fruit)
    {
        cleaner.Clean(fruit);
    }

    public void Squeeze(Fruit fruit)
    {
        squeezer.Squeeze(fruit);
    }
}
