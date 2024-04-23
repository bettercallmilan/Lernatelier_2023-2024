# Lern-Periode 4

Milan Jankovic

20.2 bis 2.4.2024

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
   
   Meine Noten in den Modulen 431 und 162 sind beide über einem 5er, was für mich von grosser Bedeutung ist. In den Modulen 117 und 164 bin ich an der LB auch gut dran und hoffe bei beiden für gute Noten.

2. Was hatten Sie sich am Ende von LP3 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   
   Mein Verbesserungsvorschlag war es, in der Freizeit mehr zu programmieren. Dies konnte ich nur zum Teil erreichen, da wir in der letzten Zeit viele Prüfungen hatten. 

3. **Neu**: Was möchten Sie Neues lernen?
   
   Ich möchte in C# neue Funktionen lernen wie z. B. dictionaries; API (async, await).

4. Was wäre ein geeignetes Projekt für diese LP4?
   
   Ich möchte meine Kalenderanwendung aus LP3 verbessern. Damit meine ich, dass die Daten in einer Datei gespeichert werden und wenn man die Applikation wieder aufmacht, dass die Daten gespeichert bleiben. Eventuell könnte ich noch einen UI machen (WinForms).

## 20.2.2024

✍️ Heute habe ich die Grob-Planung fertiggeschrieben. Ich habe dazu auf YouTube noch ein paar Tutorials angeschaut, wie mann Daten in eine Datei in C# speichert. Ich konnte noch die Arbeitspakete für die nächste Woche planen. Ich habe auch noch den fertigen Projekt (aus LP3) angeschaut und überlegt, wie ich es in WinForms umwandeln kann. (54 Wörter)

## 27.2.2024

- [ ]  WinForms GUI erstellen
- [x]  Logik für Datenverwaltung erstellen 
- [ ]  Verbindung zwischen GUI und Datenverwaltung herstellen
- [x]  Dateispeicherung implementieren

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | WinForms GUI erstellen                   | -                   | -                          |          |
| 2               | Datenverwaltungslogik                    | -                   | -                          |    x     |
| 3               | GUI & Datenverwaltung herstellen         | Eingabe GUI Element | erwünschte Ausgabe         |          |
| 4               | Termin hinzufügen / löschen / bearbeiten | Eingabe GUI Element | Speicherung in .json Datei |    x     |

✍️ Heute habe ich die Datenverwaltung fertiggemacht. Jetzt werden die Termine in einer Datei gespeichert, also d.h. wenn man den Programm schliesst und dann wieder aufmacht, sind die vorher eingegebenen Termine vorhanden. Ich konnte leider mit WinForms noch nicht anfangen, da ich zuerst die Datenspeicherung gemacht habe und am Ende nicht mehr genug Zeit hatte, dies anzufangen. (56 Wörter)

## 05.3.2024

- [x]  WinForms GUI erstellen
- [x]  Verbindung zwischen GUI und Datenverwaltung herstellen
- [x]  Startbildschirm mit Zeit und Datum (aktualisierend) erstellen
- [x]  Buttons mit Funktionen erstellen

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | WinForms GUI erstellen                   | -                   | -                          |    x     |
| 2               | GUI & Datenverwaltung herstellen         | Eingabe GUI Element | erwünschte Ausgabe         |    x     |
| 3               | Programm gestartet / Startbildschrim programmiert | -                   | Willkommensbildschirm mit Zeit/Datum  |    x     |
| 4               | Buttons mit Funktionen erstellt | erwünschte Eingabe (z. B. Termine abrufen)    | erwünschte Ausgabe (Termine werden angezeigt) |    x     |

✍️ Heute habe ich alle meine Arbeitspakete fertig machen können. Ich habe eine neue WinForms Datei erstellt und als erstes ein Menü erstellt mit all den nötigen Funktionen. Die Funktionen konnte ich aber nicht vollständig beendet, jedoch sieht der GUI schon mal gut aus. Die Datenverwaltung funktioniert auch wie erwünscht. Ich habe WinForms auch repetiert, also ist es mir jetzt viel klarer, wie es aufgebaut ist. (65 Wörter)

## 12.3.2024

- [x]  Button 'Termine erstellen' gestalten
- [x]  Button 'Termine löschen' gestalten
- [x]  Button 'Termine verändern' gestalten
- [x]  Anfangs-GUI gestalten

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | -        | - | - | x      |
| 2               | -        | - | - |  x      |
| 3               | - | - | - |    x   |
| 4               | - | -     | -   |   x     |

✍️ Heute habe ich meinen allgemeinen GUI und die Buttons besser und benutzerfreundlicher gemacht was zur einer schöneren App beigetragen hat. Man kann jetzt jeden Termin viel besser einsehen/verändern und löschen. Nächste Woche muss ich nur noch die Funktionen fertigmachen und vielleicht noch ein paar Verbesserungen und dann wäre meine Kalender-App fertig. (51 Wörter)

## 19.3.2024

- [x]  Funktion 'Termine erstellen' zu WinForms übernehmen
- [ ]  Funktion 'Termine löschen' zu WinForms übernehmen
- [ ]  Funktion 'Termine verändern' zu WinForms übernehmen
- [x]  Einzelne Forms für Funktionen verändern (nicht alles in einem Fenster)

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | Funktion Termine erstellen fertig        | Button Termine erstellen drücken | Neues Fenster mit Eingabefeld | x     |
| 2               | Funktion Termine löschen fertig         | Button Termine löschen drücken | Neues Fenster mit Eingabefeld |          |
| 3               | Funktion Termine verändern fertig | Button Termine verändern drücken | Neues Fenster mit Eingabefeld |          |
| 4               | Buttons mit Funktionen fertigerstellt | -     | -   | x       |

✍️ Heute habe ich die Fenster für 'Termine hinzufügen' und 'Termine anzeigen' gemacht. Ich konnte die anderen zwei Arbeitspakete nicht fertigstellen, da die, die ich gemacht habe schon viel Zeit bräuchten wegen den verschiedenen Sachen die ich von Form1 zu anderen Forms (Termine hinzufügen, Termine anzeigen), wie z. B. dass die eingetragenen Termine richtig angezeigt werden und immer noch in einer Datei gespeichert werden. Nächste Woche werde ich dann mit den anderen Funktionen wahrscheinlich fertig werden. (75 Wörter)

## 26.3.2024

- [x] Funktion 'Termine löschen' zu WinForms übernehmen
- [x] Funktion 'Termine verändern' zu WinForms übernehmen
- [ ] Code aufputzen
- [ ] GUI besser gestalten

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | Funktion Termine löschen fertig        | Button Termine löschen drücken | Termine gelöscht      | x       |
| 2               | Funktion Termine verändern fertig         | Button Termine verändern drücken | Termine bearbeitet     | x       |
| 3               | Einzelne (alle) Funktionen fertig         | -                          |           -              |          |
| 4               | Einzelne (alle) Funktionen fertig       |   -       |    -    |         |

✍️ Heute habe ich die Funktionen für 'Termine löschen' und 'Termine verändern' erfolgreich in mein WinForms-Projekt integriert. Die entsprechenden Buttons führen nun zu neuen Fenstern, in denen diese Aktionen ausgeführt werden können. Die anderen Aufgaben für heute habe ich noch nicht abgeschlossen, werde aber daran arbeiten, um sie bis zum nächsten Update fertigzustellen.

## 02.4.2024

- [ ] Code aufputzen
- [ ] GUI besser gestalten

| Testfall-Nummer | Ausgangslage (Given)                     | Eingabe (When)      | Ausgabe (Then)             | Erfüllt? |
| --------------- | ---------------------------------------- | ------------------- | -------------------------- | -------- |
| 1               | Einzelne (alle) Funktionen fertig         | -                          |           -              |          |
| 2               | Einzelne (alle) Funktionen fertig       |   -       |    -    |         |

✍️ Heute habe ich es nicht geschafft, den Code aufzuräumen oder die GUI zu verbessern. Das werde ich weiterhin als meine Hauptziele für die nächste LP beibehalten, damit meine App fertig und benutzerfreundlich wird.


## Reflexion


In der Lern-Periode 4 habe ich mich intensiv mit der Weiterentwicklung meiner Kalenderanwendung in C# beschäftigt. Dabei konnte ich meine Kenntnisse in der Datenverwaltung und der WinForms-GUI-Programmierung vertiefen. Mein Verbesserungsvorschlag (VBV) aus LP3, in der Freizeit mehr zu programmieren, konnte ich trotz vieler Prüfungen nur teilweise umsetzen.

Besonders positiv war mein Fortschritt bei der Datenverwaltung und der Implementierung der grundlegenden GUI-Funktionen (26.2 bis 12.3). Hier konnte ich erfolgreich die Logik für die Datenverwaltung erstellen, Dateispeicherung implementieren und eine benutzerfreundliche Oberfläche gestalten. Die Integration von neuen Funktionen wie Termine erstellen, löschen und verändern sowie die Verbindung zwischen GUI und Datenverwaltung verlief ebenfalls erfolgreich.
