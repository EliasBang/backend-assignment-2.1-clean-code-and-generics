public class StringCapsule(string content)
{
    private string _content = content;

    public string Read()
    {
        return _content;
    }

    public void Replace(string content)
    {
        _content = content;
    }
}
