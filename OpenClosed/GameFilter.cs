using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    internal class GameFilter : IFilter<Game>
    {
        public IEnumerable<Game> Filter(IEnumerable<Game> items, ISpecification<Game> specification)
        {
            foreach (Game item in items)
            { 
                if (specification.IsSatisfiedBy(item))
                    yield return item;
            }
        }
    }
}
