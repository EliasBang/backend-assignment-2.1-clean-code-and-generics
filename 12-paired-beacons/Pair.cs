public class Pair<T>
{
    public T First { get; }
    public T Second { get; }

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
}

public class PairDisplay
{
    public static void ShowPair<T>(Pair<T> pair)
    {
        Console.WriteLine(pair.First);
        Console.WriteLine(pair.Second);
    }
}