public class History<T>
{
    private readonly List<T> _items = [];
    public int Count
    {
        get
        {
            // TODONE: Les antallet fra samlingen.
            return _items.Count;
        }
    }
    public void Add(T item)
    {
        // TODONE: Oppbevar elementet.
        _items.Add(item);
    }
    public List<T> GetSnapshot()
    {
        // TODONE: Returner en samlingskopi med eksisterende elementer.

        return [.. _items];
    }
    public void Clear()
    {
        // TODONE: Tøm historikken.
        _items.Clear();
    }
}
