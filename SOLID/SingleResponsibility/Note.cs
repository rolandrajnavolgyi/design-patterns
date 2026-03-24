namespace SingleResponsibility;

internal class Note
{
    private readonly List<string> _entries;

    public Note() 
    {
        _entries = [];
    }

    public Note(IEnumerable<string> entries) : this()
    {
        _entries.AddRange(entries);
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        return _entries;
    }
}
