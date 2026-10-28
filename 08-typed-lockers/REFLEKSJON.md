# Refleksjon — Typed Lockers

## Plan før koding

-

## Testlogg

| Inndata eller handling                | Forventet resultat | Faktisk resultat |
| ------------------------------------- | ------------------ | ---------------- |
| Ny Locker<string> med "Beacon" verdi. | "Beacon"           | "Beacon"         |
| Ny Locker<int> med 42 verdi.          | 42                 | 42               |
| Overskrev lockerText med "Relay".     | "Relay"            | "Relay"          |
| Overskrev lockerNumber med 99.        | 99                 | 99               |

## Forklaring

Hva er forskjellen mellom typeargumentet int og konstruktørargumentet 42?

Mitt svar:
int bestemmer hva som er lov og 42 bestemmer verdien som skal innføres.
Hvis jeg har forstått det riktig så er grunnen til at C# er streng på typing er fordi at den tildeler plass i minnet, og forskjellige types tar forskjellig plass.

## Hva endret jeg, og hvorfor?

1. Jeg la til kommentarer i Locker.cs for å beskrive hva 'T' gjør i koden.
2. Jeg lagde to instanser av Locker i Program.cs, fordi jeg kan ikke bruke den samme for string og int.
3. Jeg la til tester i Program.cs
4. Jeg la til kommentarer i Program.cs

## Hva trenger jeg mer øving på?

Trenger litt mengdetrening på generics, men jeg forstår det mye bedre nå enn før jeg gjorde oppgaven.
