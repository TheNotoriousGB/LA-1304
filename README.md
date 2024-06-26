# Projekt-Dokumentation

Gabriel Bischof, Ensar Yildirm, John Broder

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|06.03.2024       | 1.1   | Angefangen die Dokumentation zu bearbeiten. |
|13.03.2024       | 1.2    | Wir haben uns informiert, wie wir unser Projekt umsetzen können.                                                             |
|20.03.2024       | 2.1   |  Wir haben angefangen zu programmieren.                                                              |
|27.03.2024       | 2.2   | Wir haben uns über unsere Probleme Informiert.                                                             |
|08.05.2024       | 3.1   |Wir haben unser Projekt beendet.                                                              |

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
| 5.A  |03.04.2024|Gabriel Bischof/ John Broder|Benutzerkonto verwalten können|60min|
| 6.A  |03.04.2024|Alle|Buchungsbeleg ausgeben |60min|
| 6.B  |03.04.2024|Alle|überprüfung der Buchung |60min|

Total:690min

## 3 Entscheiden

Wir haben uns entschieden, mit agilen Methoden zu arbeiten und einen Fokus darauf zu legen.



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |20.03.2024|Alle        |75 min         |300min                   |
| 1.B  |20.03.2024|Alle        |60 min         |90 min                   |
| 1.C  |20.03.2024|Alle        |45 min         |60 min                   |
| 1.D  |20.03.2024|Alle        |60 min         |80 min                   |
| 2.A  |20.03.2024|Ensar Yildirim        |60 min         |85 min                   |
| 3.A  |20.03.2024|Gabriel Bischof        |90 min         |110 min                   |
| 4.A  |20.03.2024|Alle        |120 min        |140 min                   |
| 5.A  |20.03.2024|Alle        |60 min         |75 min                   |
| 5.A  |20.03.2024|John Broder        |60 min         |75 min                   |
| 5.A  |20.03.2024|Alle        |60 min         |75 min                   |


## 5 Testen


| TC-№ | Datum | Resultat |
| ---- | ----- | -------- | 
| 1.1  |27.03.2024       |nicht OK  |        
| 2.1  |27.03.2024       |nicht Ok      |        
| 3.1  |27.03.2024       |nicht OK  |        
| 3.2  |27.03.2024       |nicht OK  |        
| 4.1  |27.03.2024       |nicht OK  |        
| 5.1  |27.03.2024       |nicht OK  |
| 6.1  |27.03.2024       |nicht OK  |        

