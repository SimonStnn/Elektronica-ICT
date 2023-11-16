# Elektronica-ICT

Samenvattingen en agenda voor Elektronica ICT Vives.

---

## Inhoudstafel

- [Ermee beginnen](#ermee-beginnen)
  - [De repository clonen](#de-repository-clonen)
  - [Vereiste vscode extenties](#vereiste-vscode-extenties)
  - [Hoe beidragen](#hoe-beidragen)
    - [Ik heb al een samenvatting gemaakt maar deze is niet in markdown, wat nu?](#ik-heb-al-een-samenvatting-gemaakt-maar-deze-is-niet-in-markdown-wat-nu)
- [Vakken](#vakken)
- [Tips](#tips)

---

## Ermee beginnen

### De repository clonen

Om te beginnen met deze repository te gebruiken, moet je eerst de repository clonen naar je eigen computer. Dit doe je door het volgende commando uit te voeren in een terminal:

```bash
git clone https://github.com/SimonStnn/Elektronica-ICT.git
```

### Vereiste vscode extenties

Nu je het project gecloned hebt, open je het in Visual Studio Code. Zorg dat je extenties hebt geïnstalleerd:

- markdownlint van David Anson
- Markdown Preview Enhanced vanYiyi Wang

### Hoe beidragen

Het is de bedoeling dat als je een samenvatting van een vak maakt, je deze in de juiste map plaatst. Bij voorkeur maak je een samenvatting in markdown, dat zit namelijk ingebouwd in github. Het is ook handig als iedereen markdown gebruikt, want dan heeft elke samenvatting dezelfde opmaak.

#### Ik heb al een samenvatting gemaakt maar deze is niet in markdown, wat nu?

Het is geen probleem als je samenvatting niet in markdown is. Je kan ze altijd pushen naar deze repo, let wel op. Voor anderen is het dan moeilijker om deze te gebruiken.

Wil je je samenvatting omzetten naar markdown kun je [deze](https://euangoddard.github.io/clipboard2markdown/) online converter gebruiken.
> **Let op!** Deze converter werkt niet altijd perfect, controleer dus altijd of de markdown goed is.
> Deze convertor is nog niet getest geweest.

Kun je je samenvatting niet omzetten naar markdown, dan kun je altijd een issue aanmaken met de vraag of iemand anders dit voor jou kan doen. Leg in de issue zeker uit waar de ander je samenvatting kan vinden.
> Het is niet de bedoeling dat je een issue aanmaakt met de vraag of iemand anders een samenvatting voor jou kan maken. Dit is een repository waar iedereen aan kan bijdragen, dus als je een samenvatting nodig hebt, maak je deze zelf.

## Vakken

- [1ste semester](./semester_1/)
  - [Applied Maths](./semester_1/applied-maths/)
  - [Communication Technology](./semester_1/communication-technology//)
  - [Digital Technology](./semester_1/digital-technology//)
  - [Electricity](./semester_1/electricity/)
  - [Electronics](./semester_1/electronics/)
  - [Introduction to programming](./semester_1/introduction-to-programming/)
  - [Process Design](./semester_1/process-design/)
  - [Web essentials](./semester_1/web-essentials/)

## Tips

Om de repository in dezelfde stijl te houden doorheen alle vakken, commits, … zijn er elke conventies. (deze gaan waarschijnlijk ook aan bod komen volgend semester)

- Commits:
  - In het engels
  - Bevelende vorm (bv.: Add README for web essentials)
  - Geen punt op het einde van de zin
  - Niet meer dan 50 karakters lang (als je commit in vscode zal deze het tonen dat je over 50 karakters zit)
- Github issues:
  - Mogen in het nederlands
  - Zorg dat je een assignee aanduid
  - Voeg ook een label toe als dit van toepassing is
- Markdown bestanden
  - Edit de markdown bestanden in vscode. Installeer ook de [vscode extenties](#vereiste-vscode-extenties). Die zullen een warning geven als bepaalde 'regels' overtreden worden.
  - Commit geen markdown bestanden met warnings (tenzij je ze niet kan oplossen of er is een specifieke reden waarom je de warning er in laat)

Als je je aan deze conventies houd dan is het voor anderen gemakkelijker om je werk te bekijken
