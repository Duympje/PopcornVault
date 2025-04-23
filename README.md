# PopcornVault
(Pro Personal Film Bibliotheek)

## Overzicht

De Pro Personal Film Bibliotheek is een professionele Windows Forms-applicatie ontworpen om gebruikers te helpen hun persoonlijke filmcollectie te beheren. Deze app biedt uitgebreide mogelijkheden voor het toevoegen, bewerken en verwijderen van films, evenals het beoordelen van films en het personaliseren van de gebruikerservaring. Naast de basisfunctionaliteiten bevat de applicatie geavanceerde zoek- en filteropties, vergelijkingstools, statistieken en nog veel meer.

## Functionaliteiten

### 1. Films Beheren

**Films Toevoegen:**
- Titel
- Jaar van uitgave
- Genre (ComboBox met vooraf gedefinieerde genres zoals Actie, Drama, Thriller, etc.)
- Regisseur
- Beoordeling (NumericUpDown van 1 tot 10)
- Beschrijving (TextBox)
- Posterafbeelding (PictureBox)
- Duur van de film (in minuten)
- IMDb-URL (voor directe toegang tot filminformatie)
- Filmprijs (indien van toepassing)

**Films Bewerken:**
- Gebruikers kunnen de informatie van films bewerken, zoals titel, genre, beoordeling, etc.

**Films Verwijderen:**
- Films kunnen worden verwijderd. Bij verwijdering moet er een bevestiging worden gevraagd.

**Films Weergeven:**
- Alle films worden weergegeven in een DataGridView. De weergave wordt automatisch geüpdatet bij elke toevoeging, bewerking of verwijdering.
- Films kunnen worden gesorteerd op titel, jaar, genre, regisseur, beoordeling, of duur.

### 2. Beoordelingen en Reviews

**Filmbeoordelingen:**
- Gebruikers kunnen een score (tussen 1 en 10) geven aan films die ze hebben gezien.
- Bij elke film wordt de gemiddelde beoordeling berekend en weergegeven.

**Reviewtekst:**
- Gebruikers kunnen een tekstuele review toevoegen aan de film. Deze wordt zichtbaar in de filmgegevens.
- Reviews kunnen worden bewerkt of verwijderd door de gebruiker die ze heeft toegevoegd.

### 3. Geavanceerde Zoeken en Filters

**Zoekfunctie:**
- Gebruikers kunnen films zoeken op titel, regisseur, genre, jaar, of beoordeling. De zoekresultaten worden dynamisch weergegeven tijdens het typen.

**Filters:**
- Gebruikers kunnen films filteren op verschillende criteria, zoals genre, jaar, beoordeling, of duur. De resultaten kunnen direct worden gefilterd in de DataGridView.

**Geavanceerde Zoekopties:**
- Mogelijkheid om te zoeken op basis van meerdere criteria tegelijk (bijvoorbeeld: drama-films van 2010 met een beoordeling van 8 of hoger).

### 4. Films Vergelijken

**Films Vergelijken:**
- Gebruikers kunnen twee films selecteren om ze naast elkaar te vergelijken op verschillende eigenschappen zoals:
  - Titel
  - Jaar
  - Regisseur
  - Genre
  - Beoordeling
  - Duur
  - Beschrijving
- De vergelijking wordt in een nieuw venster weergegeven met visuele lijnen en scheidingen om het makkelijk te maken de films naast elkaar te vergelijken.

### 5. Verlanglijst en Favorieten

**Verlanglijst:**
- Gebruikers kunnen films toevoegen aan een verlanglijst, zodat ze deze later kunnen bekijken.
- De verlanglijst moet gemakkelijk toegankelijk zijn en een aparte sectie van de applicatie bevatten.

**Favorieten:**
- Gebruikers kunnen hun favoriete films markeren. Deze films worden vervolgens in een aparte sectie Favorieten weergegeven.

### 6. Statistieken en Analyse

**Filmstatistieken:**
- Basisstatistieken zoals de meest beoordeelde film, populairste genre, en de film met de meeste beoordelingen.
- Toon de gemiddelde beoordeling per genre en per jaar.

**Beoordelingsgrafiek:**
- Voeg een grafiek toe die de beoordeling van films in verschillende genres visueel weergeeft. Dit kan worden gedaan met behulp van een grafiekbibliotheek.

### 7. Bestandsbeheer en Gegevensopslag

**Filmgegevens Opslaan:**
- Alle filmgegevens moeten worden opgeslagen in een JSON-bestand of SQL Database voor permanente opslag van films.

**Gegevensopslag voor Gebruikersinstellingen:**
- Gebruikersinstellingen (zoals voorkeuren voor sortering, filters en favoriete genres) moeten worden opgeslagen in een aparte configuratiebestand, zodat de instellingen behouden blijven bij het afsluiten van de applicatie.

**Backup en Herstel:**
- Voeg een functie toe waarmee de gebruiker een back-up van zijn filmcollectie kan maken naar een bestand en deze later kan herstellen.

## Technologieën en Hulpmiddelen

- **C# en Windows Forms** voor de GUI.
- **JSON of SQL Database** voor het opslaan van film- en gebruikersgegevens.
- **DataGridView** voor het weergeven van films in tabellen.
- **NumericUpDown** voor beoordelingen van films.
- **ComboBox** voor genres en zoekfilters.
- **PictureBox** voor het weergeven van filmomslagen.
- **TextBox** voor filmbeschrijvingen en reviewtekst.
- **LINQ** voor geavanceerde zoek- en filtermogelijkheden.
- **Charts** voor het visualiseren van beoordelingsstatistieken.
- **MessageBoxen** voor waarschuwingen en bevestigingen.

## Optionele Uitbreidingen en Extra Functies

- **Multi-taal Ondersteuning:** Maak de applicatie meertalig door middel van resourcebestanden voor vertalingen.
- **Systeem voor Herinneringen:** Voeg een herinneringssysteem toe, zodat de gebruiker wordt gewaarschuwd wanneer een nieuwe film uitkomt die overeenkomt met hun interesses.
- **Sociale Integratie:** Integreer met sociale mediakanalen zoals Facebook of Twitter om films te delen met vrienden.
- **Films Aanbevelen:** Implementeer een aanbevelingssysteem dat op basis van de beoordelingen en genres van een gebruiker films suggereert die ze misschien leuk vinden.

## Stappen voor Implementatie

1. **Opzet van de GUI:**
   - Begin met het bouwen van de gebruikersinterface, inclusief de tabbladen voor films, verlanglijst en favorieten.
   - Implementeer de benodigde DataGridView en knoppen voor het beheren van films.

2. **Gegevensbeheer en Opslag:**
   - Maak een systeem voor het opslaan van films in JSON- of SQL-formaat. Zorg ervoor dat de gegevens correct worden geladen en opgeslagen wanneer de applicatie wordt afgesloten en opnieuw geopend.

3. **Beoordelingen en Vergelijkingen:**
   - Implementeer het beoordelingssysteem, inclusief het berekenen van de gemiddelde beoordeling en het weergeven van de filmvergelijkingen.

4. **Zoek- en Filterfunctionaliteit:**
   - Bouw de zoek- en filterfunctionaliteiten zodat gebruikers snel door de filmcollectie kunnen bladeren en films kunnen vinden die aan hun voorkeuren voldoen.

5. **Statistieken en Visualisaties:**
   - Voeg de grafieken toe voor de statistieken, zoals de beoordeling per genre, en implementeer de filmvergelijkingsfunctie.

Deze versie van de Pro Personal Film Bibliotheek biedt een uitgebreid pakket van functionaliteiten en is een echte uitdaging voor zowel je programmeer- als ontwerpvaardigheden. De focus ligt op het creëren van een robuuste en gebruiksvriendelijke applicatie die de filmcollectie van de gebruiker efficiënt beheert.
