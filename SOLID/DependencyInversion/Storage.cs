namespace DependencyInversion;

internal class Storage : IStorageBrowser
{
    private readonly List<(string Name, int Size, decimal Price)> _items = [];

    public void AddItem(string name, int size, decimal price)
    {
        _items.Add((name, size, price));
    }

    public int CountBySize(int size)
    {
        return _items.Count(s => s.Size == size);
    }
}
