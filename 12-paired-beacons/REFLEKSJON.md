# Refleksjon — Paired Beacons

## Plan før koding

- Sette opp en class Pair<T> med en constructor Pair<T>(T First, Second) med Get
- Sette opp en class PairDisplay som har Pair som parameter.
- Sette opp en statisk metode i PairDisplay som skriver First og Second på hver sin linje.
- Kjøre tester.
  Jeg gjentar jo egentlig bare det som står i instruksjonene, så vet ikke om dette regnes som planlegging.

## Testlogg

| Inndata eller handling             | Forventet resultat                                      | Faktisk resultat                                        |
| ---------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| "North", "South"                   | First er North, Second er South; ShowPair skriver begge | First er North, Second er South; ShowPair skriver begge |
| 12, 24                             | First er 12, Second er 24; ShowPair skriver begge       | First er 12, Second er 24; ShowPair skriver begge       |
| To Beacon-objekter med navn A og B | First.Name er A, Second.Name er B                       | First.Name er A, Second.Name er B                       |

## Forklaring

Hvorfor trenger ikke Pair<T> vite hvilke egenskaper Beacon har? Hva gir generics her som to separate klasser ikke gir?

Mitt svar:
Fordi Pair lagrer bare referansene til beaconA og beaconB objektene, så man får direkte tilgang til Beacon sine egenskaper. Jeg vet ikke helt hva du mener med to separate klasser. To separate Pair klasser?

## Hva endret jeg, og hvorfor?

1. Jeg lagde en Pair.cs med Pair<T> class.
2. Jeg lagde PairDisplay class med en ShowPair metode.
3. Jeg satte opp tester så det skulle matche inndata og utdata testene.
   Grunnen er fordi det var det oppgaven sa jeg skulle gjøre.

## Hva trenger jeg mer øving på?

Trenger litt mer mengdetrening for å få det til å sitte ordenlig, men jeg er komfortabel med generics nå.
