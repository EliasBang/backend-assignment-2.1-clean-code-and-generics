# Refleksjon — Launch Rules

## Plan før koding

- Fjerne så mye nesting som mulig og øke lesbarheten.

## Testlogg

Første kjøring:
True

Etter refaktorering:
| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| 3, 50, true | True | True |
| 2, 50, true | False | False |
| 3, 49, true | False | False |
| 3, 50, false | False | False |

## Forklaring

Hvorfor er dette refaktorering og ikke en ny oppskytingsregel?

Mitt svar:
Kriteriene er identiske, men skrevet på en annen måte. Funksjonaliteten er lik, men hvordan det gjøres er annerledes.

## Hva endret jeg, og hvorfor?

1. Jeg snudde alle sjekkene fra å sjekke om det var godkjent til å sjekke om det ikke var godkjent.
2. Med de nye sjekkene så kunne jeg returnere tidlig og fjerne all nestingen.

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.

## Personlig kommentar

Dette er favorittoppgaven min så langt. Utrolig satisfying å se forskjellen på før og etter.
