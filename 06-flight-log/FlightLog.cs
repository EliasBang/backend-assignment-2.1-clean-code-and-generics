public class FlightLog
{
    private readonly List<string> _entries = [];
    public int Count
    {
        get
        {
            return _entries.Count();
        }
    }

    public void Add(string entry)
    {
        _entries.Add(entry);
    }

    public void Clear()
    {
        _entries.Clear();
    }
}
