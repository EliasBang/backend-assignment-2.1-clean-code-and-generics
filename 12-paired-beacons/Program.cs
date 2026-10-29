Console.WriteLine("Paired Beacons");
// TODO: Planlegg, opprett Pair.cs og PairDisplay.cs, og skriv testkallene her.
Pair<string> stringPair = new("North", "South");
PairDisplay.ShowPair(stringPair);

Pair<int> intPair = new(12, 24);
PairDisplay.ShowPair(intPair);

Beacon beaconA = new("A");
Beacon beaconB = new("B");

Pair<Beacon> beaconPair = new(beaconA, beaconB);

Console.WriteLine(beaconPair.First.Name);
Console.WriteLine(beaconPair.Second.Name);