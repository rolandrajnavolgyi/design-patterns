using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion;

internal interface IStorageBrowser
{
    int CountBySize(int size);
}
