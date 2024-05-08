# Projekt-Dokumentation

Gabriel Bischof, Ensar Yildirm, John Broder

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|06.03.2024       | 0.0.1   | Angefangen die Dokumentation zu bearbeiten. |
|13.03.2024       | ...     | Wir haben uns informiert, wie wir unser Projekt umsetzen möchten.                                                             |
|20.03.2024       | 1.0.0   |  Wir haben angefangen zu programmieren.                                                              |
|27.03.2024       | 1.0.0   | Wir haben uns über unsere Probleme Informiert.                                                             |
|08.05.2024       | 1.0.0   |Dokumentation beendet.                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Unser Projekt ist die Entwicklung eines umfassenden Veranstaltungsbuchungssystems, das Benutzern die Anzeige von verfügbaren Veranstaltungen, das Buchen von Tickets und die Verwaltung ihrer Konten ermöglicht.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss  |  Funktional | Als ein Kunde möchte ich verschiedene Veranstaltungen angezeigt bekommen, damit ich weiss welche Veranstaltung es zu buchen gibt. |
| 2   |  Muss  |  Qualität | Als ein Kunde möchte ich verschiedene Informationen zu der Veranstaltung erhalten, damit ich an den Veranstaltugen teilnehmen kann.|
| 3    |  Muss  |  Qualität   | Als ein Kunde möchte ich Benutzerkonten erstellen können, damit ich meine Buchungen angezeigt bekomme und in Zukunft weiterhin buchen kann.|
| 4    |  Muss  |  Funktional | Als ein Kunde möchte ich Tickets für die Veranstaltungen buchen können, damit ich an den Veranstaltugen teilnehmen kann.|
| 5    |  Rand  |  Qualität   | Als ein Kunde möchte ich eine Buchungsbeleg erhalten, damit ich nochmals überprüfen kann ob ich richtig gebucht habe.|
| 6    |  Muss  |  Qualität   | Als ein Kunde möchte ich meine Benutzerkonten Verwalten können, damit ich falls nötig meine Angaben bearbeiten kann.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm/Website wird gestartet/geöffnet. | - | Veranstaltungen werden angezeigt. |
| 2.1  | Auswahl einer Veranstaltung.  | Klick auf Veranstaltung | Informationen zur Veranstaltung werden angezeigt.|
| 3.1  | Auswahl von Veranstaltung  | Jetzt regristrieren (button) | Geben sie ihre Daten ein: |
| 3.2  | Eingegebene Daten  | Konto erstellen. | Erstellung des Benutzerkontos erfolgreich.|
| 4.1  | Veranstaltung auswählen  | Jetzt Buchen | Buchung erfolgreich.|
| 5.1  | Tickets gebucht.  | Datei mit einer Bestätigung wird heruntergeladen | Buchung erfolgreich.|
| 6.1  | Benutzerkonto erstellt  | Benutzerkonto bearbeiten. | Ihre Daten:|

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |03.04.2024|John Broder|API erstellen mit Datenbank|75min|
| 1.B  |03.04.2024|Ensar Yildirim|erstellen von Controller|60min|
| 1.C  |03.04.2024|John Broder|Speicherung von Daten in der Datenbank|45min|
| 1.D  |03.04.2024|Gabriel Bischof|Veranstaltungen Anzeigen lassen|60min|
| 2.A  |03.04.2024|Gabriel Bischof|Informationen zu den Veranstaltungen anzeigen|60min|
| 3.A  |03.04.2024|Ensar Yildirim|Buchen von Tickets für die veranstaltungen|90min|
| 4.A  |03.04.2024|Gabriel Bischof/ John Broder|Benutzerkonto erstellen|120min|
| 5.A  |03.04.2024|Gabriel Bischof/ John Broder|Benutzerkonto verwlen können|60min|
| 6.A  |03.04.2024|Alle|Buchungsbeleg ausgeben |60min|
| 6.B  |03.04.2024|Alle|überprüfung der Buchung |60min|

Total:690min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
