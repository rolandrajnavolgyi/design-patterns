using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution;

internal static class AreaCalculator
{
    public static int CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}
