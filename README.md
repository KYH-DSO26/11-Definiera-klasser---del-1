# Grundläggande programmering i C# – Definiera klasser (Del 1)

Välkommen till kodbasen för lektionen **"Definiera klasser – del 1"**. Det här repot innehåller allt material som vi gick igenom under vår code-along-session. Spara gärna ner eller klona repot för att använda projekten som referens och studiematerial.

## 🏛 Struktur i Visual Studio
Projektet är uppbyggt som en sammanhållen **Visual Studio Solution (.sln)** som innehåller **15 separata projekt (Projects)**. Varje projekt representerar en övningsuppgift och är en fristående, körbar konsolapplikation.

Projekten är färgkodade och uppdelade i stigande svårighetsgrad för att steg för steg bygga upp förståelsen för objektorienterad programmering (OOP):

### 🟢 Gröna projekt (Grundläggande koncept)
*Fokus på grundläggande syntax, skapa klasser, fält och instansiera objekt.*
*   **Projekt 1: Bilapplikation** – Skapa enkla klasser och använda publika fält.
*   **Projekt 2: Hundapplikation** – Introduktion av konstruktorer (`new`) för att initiera objekt.
*   **Projekt 3: Produktapplikation** – Lägga till beteende i klasser med hjälp av metoder.
*   **Projekt 4: Användarapplikation** – Använda automatiska egenskaper (properties) med `get` och `set`.
*   **Projekt 5: Maträttsapplikation** – Introduktion av enumerationer (`enum`) för kategorisering.

### 🟡 Gula projekt (Tillämpning & Logik)
*Kombinerar metoder och egenskaper med logik (validering) för att kapsla in data.*
*   **Projekt 6: Bankapplikation** – Skydda interna variabler (`private`) och styra tillstånd via insättning/uttag.
*   **Projekt 7: Rektangelapplikation** – Använda beräknade egenskaper (read-only properties).
*   **Projekt 8: Kursapplikation** – Enkel hantering och kontroll av externa objekt.
*   **Projekt 9: Termometerapplikation** – Skriva valideringslogik direkt i en egenskaps `set`-accessor.
*   **Projekt 10: Orderapplikation** – Styra en statuskedja sekventiellt med hjälp av en `enum`.

### 🔴 Röda projekt (Avancerad utmaning & Fördjupning)
*Avancerade applikationer som visar hur objekt hanterar sina egna tillståndsgränser och interagerar med varandra.*
*   **Projekt 11: Tamagotchiapplikation** – Hantera inre logiska gränsvärden (förhindra negativa värden).
*   **Projekt 12: Biluthyrning** – Objektinteraktion (hur ett objekt skickas som parameter och förändrar ett annats tillstånd).
*   **Projekt 13: Lagerapplikation** – Tvinga fram affärsregler och marginalkrav via konstruktor och egenskaper.
*   **Projekt 14: RPG Karaktär** – En stridssimulator där karaktärer attackerar varandra och hanterar hälsa/svimning.
*   **Projekt 15: Smart Hem** – En mer avancerad tillståndsmaskin för en lampa som håller reda på drifttimmar baserat på klick.

---

## 🚀 Hur du använder det här repot
1. **Klona eller ladda ner** repot till din dator.
2. Öppna solution-filen (`.sln`) i **Visual Studio**.
3. För att köra ett specifikt projekt:
   * Högerklicka på det projekt du vill köra i *Solution Explorer*.
   * Välj **"Set as Startup Project"** (Sätt som startprojekt).
   * Tryck på **F5** eller *Start*-knappen för att köra applikationen.

## 🎯 Centrala begrepp att ta med sig
Under lektionen har vi gått igenom följande viktiga byggstenar inom OOP:
*   **Klass:** Ritningen eller mallen för ett objekt.
*   **Objekt (Instans):** Det faktiska hantverket eller "huset" som byggs i datorns minne utifrån ritningen.
*   **Inkapsling:** Att dölja interna fält (`private`) och endast tillåta säker åtkomst via egenskaper eller metoder för att **bibehålla objektets tillstånd**.
