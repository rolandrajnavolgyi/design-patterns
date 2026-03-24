using System.Diagnostics;

namespace SingleResponsibility;

internal class NotePersister
{
    private readonly string _path;

    public NotePersister()
    {
        _path = System.IO.Path.Combine(Environment.CurrentDirectory, "notes.txt");
    }

    public void Save(Note note)
    {
        File.WriteAllLines(_path, note.GetEntries());
    }

    public Note Load()
    {
        var entries = File.ReadAllLines(_path);
        return new Note(entries);
    }

    public void Open()
    {
        var psi = new ProcessStartInfo
        {
            FileName = _path,
            UseShellExecute = true
        };
        Process.Start(psi);
    }
}
