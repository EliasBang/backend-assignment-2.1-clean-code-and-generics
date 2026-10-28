public class Locker<T> // T virker som en placeholder for typen (string, int, osv.) som defineres når man lager en instance av classen.
{
    private T _content; // Hvis man kjørte Locker<string> _ = new() så er T _content en string. Hvis man kjørte Locker<int> så er T _content en int.

    public Locker(T content) // Hvis man kjørte Locker<string> _ = new() så er T content en string. Hvis man kjørte Locker<int> så er T content en int.
    {
        _content = content;
    }

    public T Read() // Locker<string> betyr at denne metoden returnerer en string. Locker<int> betyr at den returnerer en int.
    {
        return _content;
    }

    public void Replace(T content) // Hvis Locker<float> så overskriver den _content med en ny float. Hvis<string> eller <int> så blir det string eller int istedet.
    {
        _content = content;
    }
}