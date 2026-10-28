# Refleksjon — Twin Recorders

## Plan før koding

-

## Testlogg

| Inndata eller handling  | Forventet resultat                            | Faktisk resultat                              |
| ----------------------- | --------------------------------------------- | --------------------------------------------- |
| Legg til "Orbit" / 7    | Begge har Count 1                             | Begge har Count 1                             |
| Søk etter "Orbit" / 7   | Begge gir true                                | Begge gir true                                |
| Søk etter "Landing" / 9 | Begge gir false                               | Begge gir false                               |
| Clear på begge          | Begge har Count 0 og finner ikke gammel verdi | Begge har Count 0 og finner ikke gammel verdi |
| Clear på tom beholder   | Count forblir 0                               | Count forblir 0                               |

## Forklaring

Hva måtte vært forskjellig i reglene for at du ville beholdt to separate klasser?

Mitt svar:
Hvilke regler?

## Hva endret jeg, og hvorfor?

1. Jeg la til \_items.Clear() i både TextRecorder og NumberRecorder.
2. Jeg la alle testene spesifisert i README.md inn i Program.cs

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
