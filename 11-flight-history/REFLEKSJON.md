# Refleksjon — Flight History

## Plan før koding

-

## Testlogg

| Inndata eller handling                         | Forventet resultat                           | Faktisk resultat                             |
| ---------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| Ny historikk, GetSnapshot                      | Tom liste                                    | Tom liste                                    |
| Add("Launch"), Add("Orbit")                    | Count 2; kopi inneholder Launch, Orbit       | Count 2; kopi inneholder Launch, Orbit       |
| Fjern alle elementer fra kopien                | Historikken har fortsatt Count 2             | Historikken har fortsatt Count 2             |
| Hent ny kopi, legg til "Landing" i historikken | Kopien har Count 2; historikken har Count 3  | Kopien har Count 2; historikken har Count 3  |
| Clear på historikken                           | Count 0; tidligere kopi har fortsatt Count 2 | Count 0; tidligere kopi har fortsatt Count 2 |

## Forklaring

Hva vil fremdeles være delt dersom T senere er en klasse med endringsbare egenskaper?

Mitt svar:
Hvis T er en class så tror jeg den nye lista kopierer referansen istedetfor selve innholdet, så da vil både history og snapshot endre på samme class instance.

## Hva endret jeg, og hvorfor?

1. Jeg bytta ut return 0 med return \_items.Count
2. Jeg la til \_items.Add(item)
3. Jeg la til return [.._items]
4. Jeg la til \_items.Clear()
5. Jeg forenklet new List<T>() til []
6. Jeg la til tester i Program.cs

## Hva trenger jeg mer øving på?

Jeg slet med å forstå noen av spørsmålene på denne oppgaven. Spesifikt Steg 4 i Oppdrag, og Forklaring i Refleksjonen. Jeg endte opp med å bruke AI (for første gang hittil) for å tolke spørsmålene. Men når jeg først forsto oppgavene så gikk det ganske lett.
