using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed;

internal class PlatformSpecification(Platform platform) : ISpecification<Game>
{
    public bool IsSatisfiedBy(Game item)
    {
        return item.Platform == platform;
    }
}
