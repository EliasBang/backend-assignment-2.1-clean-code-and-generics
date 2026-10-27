# Refleksjon — Signal Types

## Plan før koding

- label er string,
  retries er int,
  messages er en List som godtar strings,
  result er string
  RepeatLabel tar imot strings som parameter.

## Testlogg

| Inndata eller handling | Forventet resultat                                  | Faktisk resultat                                    |
| ---------------------- | --------------------------------------------------- | --------------------------------------------------- |
| 42                     | int argument kan ikke blir brukt i string parameter | int argument kan ikke blir brukt i string parameter |
| "42"                   | READY                                               | READY                                               |
| ---------------------- | --------------------------------------------------- | --------------------------------------------------- |
| retries = "three"      | int variabel kan ikke ha string som verdi           | int variabel kan ikke ha string som verdi           |
| retries = 3            | retries == 3                                        | retries == 3                                        |

## Forklaring

Er string i List<string> en tekstverdi eller en type? Hvorfor kan ikke var retries senere bli tekst?

Mitt svar:

string er en type. List<string> betyr at List bare godtar typen strings som verdier. I "abcdefg" så er typen string, mens "abcdefg" er verdien.
'var' bestemmer typen ut ifra første verdien den får (tror jeg), så etter retries har blitt initialisert så er 'var' egentlig 'int'.

## Hva endret jeg, og hvorfor?

1. Jeg stokka om på rekkefølgen så linjene som er relatert kommer etter hverandre.
2. Jeg uncommenta 'retries = "three"' og 'messages.Add(42)'
3. Jeg gjorde argumentet i 'messages.Add(42)' om til en string ved å endre det til 'messages.Add("42")'
4. Jeg gjorde argumentet i 'retries = "three"' om til en int ved å endre det til 'retries = 3'
5. Jeg fjerna TODO kommentaren.

## Hva trenger jeg mer øving på?

Jeg kan ikke se noe i denne oppgaven jeg trenger mer øving på, men jeg tar gjerne imot feedback.
