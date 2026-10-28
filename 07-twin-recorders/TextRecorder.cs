public class TextRecorder
{
    private readonly List<string> _items = [];
    public int Count { get { return _items.Count; } }
    public void Add(string item) { _items.Add(item); }
    public bool Contains(string item) { return _items.Contains(item); }
    public void Clear()
    {
        _items.Clear();
    }
}

// Alle linjene er like som NumberRecorder, bare med string istedetfor int.
