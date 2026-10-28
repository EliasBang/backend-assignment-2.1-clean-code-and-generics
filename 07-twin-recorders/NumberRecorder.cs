public class NumberRecorder
{
    private readonly List<int> _items = [];
    public int Count { get { return _items.Count; } }
    public void Add(int item) { _items.Add(item); }
    public bool Contains(int item) { return _items.Contains(item); }
    public void Clear()
    {
        _items.Clear();
    }
}

// Alle linjene er like som TextRecorder, bare med int istedetfor string.