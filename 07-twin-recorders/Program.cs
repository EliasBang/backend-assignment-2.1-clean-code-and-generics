TextRecorder text = new();
NumberRecorder numbers = new();

text.Add("Orbit");
numbers.Add(7);
Console.WriteLine($"text count: {text.Count}");
Console.WriteLine($"numbers count: {numbers.Count}");

Console.WriteLine($"text contains 'Orbit': {text.Contains("Orbit")}");
Console.WriteLine($"numbers contains 7: {numbers.Contains(7)}");

Console.WriteLine($"text contains 'Landing': {text.Contains("Landing")}");
Console.WriteLine($"numbers contains 9: {numbers.Contains(9)}");

text.Clear();
numbers.Clear();
Console.WriteLine($"text count: {text.Count}");
Console.WriteLine($"numbers count: {numbers.Count}");

Console.WriteLine($"text contains 'Orbit': {text.Contains("Orbit")}");
Console.WriteLine($"numbers contains 7: {numbers.Contains(7)}");

text.Clear();
numbers.Clear();

Console.WriteLine($"text count: {text.Count}");
Console.WriteLine($"numbers count: {numbers.Count}");