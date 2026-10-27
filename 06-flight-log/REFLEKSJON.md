# Refleksjon — Flight Log

## Plan før koding

-

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| Ny logg                | 0                  | 0                |
| Add("Launch")          | 1                  | 1                |
| Add("Orbit")           | 2                  | 2                |
| Clear()                | 0                  | 0                |
| Clear() igjen          | 0                  | 0                |
| Add("")                | 1                  | 1                |

## Forklaring

Hva kan gå galt hvis både listen og et eget tellerfelt lagrer antallet?

Mitt svar: De kan desynkroniseres og ha forskjellige verdier.

## Hva endret jeg, og hvorfor?

1. Jeg endret return 0 til return \_entries.Count() slik at det skulle være 1 source of truth.
2. Jeg la til \_entries.Add(entry) i Add metoden.
3. Jeg la til \_entries.Clear() i Clear metoden.
4. Fjerna TODO kommentarer.
5. Jeg la til nye tester i Program.cs
6. Jeg la til mellomrom mellom linjene i Program.cs For å gjøre det lettere å lese.

## Hva trenger jeg mer øving på?

Static og classes. Spesielt 'get', 'set' og sånt.
