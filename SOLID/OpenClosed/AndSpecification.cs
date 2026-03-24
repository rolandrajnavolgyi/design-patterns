using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed;

internal class AndSpecification<T>(ISpecification<T> left, ISpecification<T> right) : ISpecification<T>
{
    public bool IsSatisfiedBy(T item)
    {
        return left.IsSatisfiedBy(item) && right.IsSatisfiedBy(item);
    }
}
