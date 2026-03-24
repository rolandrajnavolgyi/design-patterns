using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed;

internal class GenreSpecification(Genre genre) : ISpecification<Game>
{
    public bool IsSatisfiedBy(Game item)
    {
        return item.Genre == genre;
    }
}
