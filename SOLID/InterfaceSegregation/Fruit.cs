using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation;

internal class Fruit(string name)
{
    public override string ToString()
    {
        return name;
    }
}
