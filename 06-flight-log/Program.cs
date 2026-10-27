FlightLog log = new();
Console.WriteLine(log.Count);

log.Add("Launch");
Console.WriteLine(log.Count);

log.Add("Orbit");
Console.WriteLine(log.Count);

log.Clear();
Console.WriteLine(log.Count);

log.Clear();
Console.WriteLine(log.Count);

log.Add("");
Console.WriteLine(log.Count);