History<string> history = new();
List<string> snapshot = history.GetSnapshot();
Console.WriteLine("snapshot.Count: " + snapshot.Count);

history.Add("Launch");
history.Add("Orbit");
snapshot = history.GetSnapshot();
Console.WriteLine("\nhistory.Count: " + history.Count);
Console.WriteLine("snapshot.Count: " + snapshot.Count);
Console.WriteLine("snapshot.Contains('Launch'): " + snapshot.Contains("Launch"));
Console.WriteLine("snapshot.Contains('Orbit'): " + snapshot.Contains("Orbit"));


snapshot.Clear();
Console.WriteLine("\nhistory.Count: " + history.Count);
// TODONE: Legg til resten av testene, også med int.

snapshot = history.GetSnapshot();
history.Add("Landing");
Console.WriteLine("\nhistory.Count: " + history.Count);
Console.WriteLine("snapshot.Count: " + snapshot.Count);

history.Clear();
Console.WriteLine("\nhistory.Count: " + history.Count);
Console.WriteLine("snapshot.Count: " + snapshot.Count);



History<int> historyInt = new();
historyInt.Add(42);
Console.WriteLine("\nHistory int count: " + historyInt.Count);