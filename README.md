# Konsolen-Taschenrechner

Ein Taschenrechner, der komplett in der Konsole läuft. Mein Einstiegsprojekt in C#.

Das Programm fragt nacheinander zwei Zahlen und eine Rechenart ab, rechnet und
gibt das Ergebnis aus. Danach fragt es, ob noch eine Rechnung folgen soll.

## Was er kann

- Die vier Grundrechenarten: `+`, `-`, `*`, `/`
- Division durch null wird abgefangen und meldet einen Fehler, statt ein
  unsinniges Ergebnis auszugeben
- Eingaben, die keine Zahl sind, führen zu einer Meldung statt zum Absturz
- Rechnet in einer Schleife weiter, bis man mit `n` beendet

## Starten

Du brauchst das [.NET SDK](https://dotnet.microsoft.com/download) (Version 10).

```bash
git clone https://github.com/JulianHarder/Consolen-Taschenrechner.git
cd Consolen-Taschenrechner/Taschenrechner
dotnet run
```

## Beispiel

```
Willkommen beim Taschenrechner
Bitte gib die erste Zahl ein
> 12.5
Gib die zweite Zahl ein
> 4
Wähle eine rechenart: + - * /
> *
Ergebnis: 50
Nochmal rechnen? (j/n
> n
Danke fürs Rechnen, bis bald!
```

Kommazahlen werden mit Punkt eingegeben (`12.5`), nicht mit Komma.

## Hinweis

Ein Lernprojekt, kein fertiges Werkzeug. Eine bekannte Schwachstelle: Bricht man
die Eingabe mit <kbd>Strg</kbd>+<kbd>D</kbd> ab, beendet sich das Programm mit
einer `ArgumentNullException` – abgefangen wird bisher nur die `FormatException`.

Im Browser ausprobieren (nachgebautes Terminal):
[julian-harder.julianharder99.workers.dev](https://julian-harder.julianharder99.workers.dev/projekt.html?id=taschenrechner)
