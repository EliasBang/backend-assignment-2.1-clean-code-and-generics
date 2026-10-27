# Refleksjon — Sample Capsule

## Plan før koding

- Følger bare hva det står i README.md

## Testlogg

| Inndata eller handling | Forventet resultat | Faktisk resultat |
| ---------------------- | ------------------ | ---------------- |
| "dust", "ice"          | "dust", "ice"      | "dust", "ice"    |
| "rock", "ice"          | "rock", "ice"      | "rock", "ice"    |
| ---------------------- | ------------------ | ---------------- |
| "dust", "ice"          | "dust", "ice"      | "dust", "ice"    |
| "", "ice"              | "", "ice"          | "", "ice"        |

## Forklaring

Hvorfor skal \_content være et instansfelt og ikke static?

Mitt svar:
Hvis \_content er static så får vi resultatet "ice", "ice", "rock", "rock". Jeg antar dette er fordi at \_content i de to StringCapsule ikke blir behandlet som separate felt lenger.

## Hva endret jeg, og hvorfor?

1. Jeg flytta StringCapsule parameteret inn i toppen av classen. Gjorde det så det skal se litt ryddigere ut.
2. Jeg satte \_content = content istedetfor \_content = "". Siden jeg fjerna StringCapsule metoden så må jeg initialisere den direkte.
3. Jeg la til return \_content i Read metoden. For å returnere innholdet i \_content.
4. Jeg la til \_content = content i Replace metoden. Gjorde det så man kan oppdatere verdien i \_content.
5. Fjerna TODO kommentarer
6. La til noen tomme linjer i Program.cs så det skal bli lettere for øynene.

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
