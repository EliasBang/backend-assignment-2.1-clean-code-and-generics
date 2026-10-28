# Refleksjon — Signal Printer

## Plan før koding

-

## Testlogg

| Inndata eller handling | Forventet resultat           | Faktisk resultat             |
| ---------------------- | ---------------------------- | ---------------------------- |
| "SOS", "ACK"           | SOS og ACK på hver sin linje | SOS og ACK på hver sin linje |
| 4, 8                   | 4 og 8 på hver sin linje     | 4 og 8 på hver sin linje     |
| Tom List<int>          | Ingen linjer fra metoden     | Ingen linjer fra metoden     |

## Forklaring

Hvor er T deklarert, og hvordan skiller dette seg fra Recorder<T>?

Mitt svar:
T er deklarert i metoden PrintItems og ikke i classen. Det endrer ikke så mye, bortsett fra at jeg trenger ikke å lage en class instance hver for int og string, jeg kan bare kalle metoden. Jeg må likevel sette opp en typed list, så i praksis er det er ikke så stor forskjell i dette eksempelet.

## Hva endret jeg, og hvorfor?

1. Jeg endret navnet på PrintStrings til PrintItems i SignalPrinter.cs
2. Jeg la til <T> etter PrintItems, og bytta ut <string> med <T>
3. Jeg oppdaterte metode kallet i Program.cs.
4. Jeg la til noen tester i Program.cs

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
