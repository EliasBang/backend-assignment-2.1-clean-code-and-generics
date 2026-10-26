List<string> availableCrew = ["Ada", "Bo", "Cy"];

Console.WriteLine($"Crew: {availableCrew.Count}");

// The mission requires minimum 3 available crewmembers for security reasons.
if (availableCrew.Count >= 3)
{
    Console.WriteLine("Ready");
}
else
{
    Console.WriteLine("Waiting");
}