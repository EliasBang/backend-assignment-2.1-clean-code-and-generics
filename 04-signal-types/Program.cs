var retries = 3;
retries = 3;

string label = "READY";

List<string> messages = [label, label];
messages.Add("42");

string result = RepeatLabel(label);

Console.WriteLine(result);


static string RepeatLabel(string message)
{
    return $"Echo: {message}";
}
