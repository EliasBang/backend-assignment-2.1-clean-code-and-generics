# Refleksjon — Universal Recorder

## Plan før koding

-

## Testlogg

| Inndata eller handling    | Forventet resultat                              | Faktisk resultat                                |
| ------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| Ny Recorder<int>          | Count 0, Contains(7) false                      | Count 0, Contains(7) false                      |
| Legg til 7 to ganger      | Count 2, Contains(7) true                       | Count 2, Contains(7) true                       |
| Clear                     | Count 0, Contains(7) false                      | Count 0, Contains(7) false                      |
| Tekstbeholder med "Orbit" | Contains("Orbit") true, Contains("orbit") false | Contains("Orbit") true, Contains("orbit") false |

## Forklaring

Hvorfor er det feil å erstatte absolutt alle typer i klassen med T?

Mitt svar:
Fordi med Count vil du vite hvor mange det er (et nummer/int), så da gir det ikke mening å gjøre det til generic.
Med contains så vil du vite om noe finnes eller ikke (ja og nei/bool), så da gir det heller ikke mening å gjøre det til generic.

## Hva endret jeg, og hvorfor?

1. Jeg la til <T> etter classname, og jeg bytta ut alle <string> med <T> i Recorder.cs
2. Jeg la til tester i Program.cs

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
