Console.WriteLine("Int tests:");

Recorder<int> recorderInt = new();
Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));

recorderInt.Add(7);
recorderInt.Add(7);
Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));

recorderInt.Clear();
Console.WriteLine(recorderInt.Count);
Console.WriteLine(recorderInt.Contains(7));

Console.WriteLine("\nString tests:");

Recorder<string> recorderString = new();
recorderString.Add("Orbit");
Console.WriteLine(recorderString.Contains("Orbit"));
Console.WriteLine(recorderString.Contains("orbit"));
