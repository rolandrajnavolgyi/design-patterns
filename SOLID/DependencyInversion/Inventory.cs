using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion;

internal class Inventory(IStorageBrowser browser)
{
    public void PrintItemSizeCount(int size)
    {
        Console.WriteLine($"There are {browser.CountBySize(size)} items of size {size}.");
    }
}
