namespace OpenClosed;

internal interface ISpecification<T>
{
    bool IsSatisfiedBy(T item);
}
