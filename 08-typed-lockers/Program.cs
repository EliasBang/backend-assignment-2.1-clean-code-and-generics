Console.WriteLine("Typed Lockers");
// TODONE: Opprett, bruk og test to skap med ulike typeargumenter.
Locker<string> lockerText = new("Beacon");
Locker<int> lockerNumber = new(42);

Console.WriteLine(lockerText.Read());
Console.WriteLine(lockerNumber.Read());

lockerText.Replace("Relay");
lockerNumber.Replace(99);

Console.WriteLine(lockerText.Read());
Console.WriteLine(lockerNumber.Read());

/// Kan ikke bytte int inn i en string, og kan ikke sette en string inn i en int.
// lockerText.Replace(99);
// lockerNumber.Replace("Relay");