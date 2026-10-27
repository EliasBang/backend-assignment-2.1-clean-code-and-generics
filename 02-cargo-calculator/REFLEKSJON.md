# Refleksjon — Cargo Calculator

## Plan før koding

-

## Testlogg

Første kjøring:
Remaining: 7
Remaining: 12

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| 12, 5                  | 7                  | 7                |
| 5, 12                  | -7                 | -7               |
| 20, 8                  | 12                 | 12               |
| 8, 20                  | -12                | -12              |
| 5000, 5                | 4995               | 4995             |
| 2000, 8                | 1992               | 1992             |

## Forklaring

Hva er parameterne, argumentene og returverdien i ett av kallene dine?

Mitt svar:
Parameterene er int capacity og int usedCapacity.
Argumentene er int: firstCapacity = 12 og int: firstUsedCapacity = 5.
Returverdien er capacity (12) - usedCapacity (5) = 7

## Hva endret jeg, og hvorfor?

1. Jeg lagde en method som returnerer capacity minus usedCapacity.
2. Jeg bytta ut de to utregningene med en method call.
3. Jeg fjerna TODO kommentaren.

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
