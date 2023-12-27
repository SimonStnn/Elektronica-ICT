# Leerstof ondersteunende vragen

## Inhoudstafel

- [Leerstof ondersteunende vragen](#leerstof-ondersteunende-vragen)
  - [Inhoudstafel](#inhoudstafel)
  - [Hoofdstuk 1: Inleiding](#hoofdstuk-1-inleiding)
  - [Hoofdstuk 2: Digitaal rekenen](#hoofdstuk-2-digitaal-rekenen)
  - [Hoofdstuk 3: Algebra van Boole](#hoofdstuk-3-algebra-van-boole)
  - [Hoofdstuk 4: Bistabiele elementen](#hoofdstuk-4-bistabiele-elementen)
  - [Hoofdstuk 5: Registers](#hoofdstuk-5-registers)
  - [Hoofdstuk 6: Tellers](#hoofdstuk-6-tellers)
  - [Hoofdstuk 7: sequentiële systemen](#hoofdstuk-7-sequentiële-systemen)

## Hoofdstuk 1: Inleiding

Wat beschrijft het **theorema van Shannon** met betrekking tot het bemonsteren van analoge signalen?

> antwoord

Wat betekent **aliasing** met betrekking tot het bemonsteren van analoge signalen?

> antwoord

Wat is **positieve logica**?

> antwoord

Wat is **negatieve logica**?

> antwoord

Verklaar de betekenis van volgende parameters en wat is de waarde voor **TTL**?

> - V<sub>OHmin</sub> :
> - V<sub>OLmax</sub> :
> - V<sub>IHmin</sub> :
> - V<sub>ILmax</sub> :

Wat is de **ruismarge** bij TTL en hoeveel is dit voor de hoge en lage niveaus?

> antwoord

Wat is de **statische vermogendissipatie** van een digitale poort?

> antwoord

Wat is het **power delay product** en wat omschrijft deze parameter?

> antwoord

Wat beschrijven de parameters **fan-in**, **fan-out**?

> antwoord

Wat doe je met **ongebruikte ingangen** en **ongebruikte uitgangen**? Waarom?

> antwoord

Wat is **ontkoppelen** van de voeding van logische bouwstenen?

> antwoord

Bespreek een nuttige toepassing voor poorten met **tri-state** uitgang.

> antwoord

Bespreek een nuttige toepassing voor poorten met **open-collector** uitgang.

> antwoord

## Hoofdstuk 2: Digitaal rekenen

Zet een decimaal getal, met fractie, om naar het binaire, octale of hexadecimale getalstelsel, tot maximum 4 digits na de komma.

> Voorbeeld: (133,45)<sub>10</sub> = (?)<sub>2</sub> = (?)<sub>8</sub> = (?)<sub>16</sub>
>
> antwoord

**Gegeven**: twee decimale getallen, A en B, bijvoorbeeld A = (248)<sub>10</sub> en B = (115)<sub>10</sub>

**Opgave**: zet de getallen om in binaire code en bepaal A - B, B - A, A x B

> antwoord

**Gegeven**: twee decimale getallen, A en B, bijvoorbeeld A = (248)<sub>10</sub> en B = (115)<sub>10</sub>

**Opgave**: toon aan, na binaire omzetting, dat A - B identiek is aan de som van A en het 2-complement van B

> antwoord

**Gegeven**: twee decimale getallen, A en B, bijvoorbeeld A = (248)<sub>10</sub> en B = (17)<sub>10</sub>

**Opgave**: bepaal A/B

- A.d.h.v. het gewone verschil
  > antwoord
- A.d.h.v. het 2-complement
  > antwoord
- A.d.h.v. het 1-complement
  > antwoord

**Gegeven**: twee floating point getallen A en B

**Opgave**:

- bepaal **A + B** door normalisatie van de exponenten
  > antwoord
- Bepaal **A x B** door normalisatie van de exponenten
  > antwoord

**Gegeven**: een decimaal getal A, bijvoorbeeld A = (9)10

**Opgave**:

- Bepaal de **2421** voorstelling van A
  > antwoord
- Bepaal de **5211** voorstelling van A
  > antwoord
- Bepaal de **842̅1̅** voorstelling van A
  > antwoord
- Bepaal de **XS3** voorstelling van A
  > antwoord

Wat is een **zelfcomplementerende** code?

> antwoord

Wat is een **cyclische** code?

> antwoord

## Hoofdstuk 3: Algebra van Boole

Beschrijf de 4 gelijkheden die ook gekend zijn als de Wetten van **De Morgan**.

> antwoord

Wat beschrijft de **distributieve wet**? Hoe kan deze wet toegepast worden om logische functies te vereenvoudigen?

> antwoord

Wat is de **absorptiewet**? Hoe kan deze wet toegepast worden om logische functies te vereenvoudigen?

> antwoord

Toon aan dat A + A \* B = A

> antwoord

Toon aan dat A + A̅ \* B = A + B

> antwoord

**Gegeven**: een logische functie F(A,B,C, …)

**Opgave**: vereenvoudig deze functie maximaal door het toepassen van de Boolese wetten.

> antwoord

**Gegeven**: een logische functie F(A,B,C, …)

**Opgave1**: bepaal de standaard-som-vorm.

> antwoord

**Opgave2**: bepaal de standaard-product-vorm.

> antwoord

**Gegeven**: een logische functie van 2 of 3 of 4 of 5 variabelen (F(A,B,C,D,E))

**Opgave**: vereenvoudig de functie d.m.v. een Karnaugh-kaart.

> antwoord

**Gegeven**: een toepassing met logische variabelen

**Opgave1**: vereenvoudig de functie d.m.v. Boolese wetten

> antwoord

**Opgave2**: vereenvoudig de functie d.m.v. een Karnaugh-kaart

> antwoord

**Opgave3**: hoe kan de vereenvoudigde functie gerealiseerd worden door enkel NAND-poorten te gebruiken?

> antwoord

**Opgave4**: hoe kan de vereenvoudigde functie gerealiseerd worden door enkel NOR-poorten te gebruiken?

> antwoord

**Opgave**: ontwerp een schakeling die twee bits optelt, en rekening houdt met een eventuele **carry**. Stel de waarheidstabel op en bepaal de vereenvoudigde vergelijkingen voor de som S en de carry out C<sub>o</sub>.

> antwoord

**Opgave**: hoe kan een N-bits Adder (bijvoorbeeld N = 2, 4, 8, …) worden gebouwd, door gebruik te maken van een 1-bits Full Adder? Teken de hardware!

> antwoord

**Opgave**: ontwerp een 1-bits subtractor, die rekening houdt met een eventuele borrow. Stel de waarheidstabel op en bepaal de vereenvoudige vergelijkingen voor het verschil V en de borrow out B<sub>o</sub>.

> antwoord

**Opgave**: hoe kan een 1-bits subtractor opgebouwd worden door gebruik te maken van een Full Adder?

> antwoord

**Opgave**: hoe kan een N-bits Subtractor (bijvoorbeeld N = 2, 4, 8, …) worden gebouwd, door gebruik te maken van een 1-bits Subtractor? Teken de hardware!

> antwoord

## Hoofdstuk 4: Bistabiele elementen

**Gegeven**: het type bistabiel element is een **NOR-latch**.

**Opgave**:

- Teken de **hardware** van een NOR-latch, met inputs A en B en uitgangen X en Y.

  > antwoord

- Bepaal de **waarheidstabel** van X<sub>tn+1</sub> en Y<sub>tn+1</sub> a.d.h.v. de inputs A, B, X<sub>tn</sub> en Y<sub>tn</sub>.

  > antwoord

- Bepaal de **verkorte waarheidstabel** van een NOR-latch door A, B, X<sub>tn</sub> en Ytn te vervangen door R, S, Q en Q̅.

  > antwoord

- Waarom zijn de uitgangen van een NOR-latch **onvoorspelbaar** als de NOR-latch de transitie maakt van de aansturing AB = 11 naar de aansturing AB = 00?

  > antwoord

- Bepaal de **excitatietabel** van een NOR-latch a.d.h.v. de verkorte waarheidstabel.
  > antwoord

**Gegeven**: het type bistabiel element is een **NAND-latch**.

**Opgave**:

- Teken de **hardware** van een NOR-latch, met inputs A en B en uitgangen X en Y.

  > antwoord

- Bepaal de **waarheidstabel** van X<sub>tn+1</sub> en Y<sub>tn+1</sub> a.d.h.v. de inputs A, B, X<sub>tn</sub> en Y<sub>tn</sub>.

  > antwoord

- Bepaal de **verkorte waarheidstabel** van een door A, B, X<sub>tn</sub> en Ytn te vervangen door S̅, R̅, Q en Q̅.

  > antwoord

- Waarom zijn de uitgangen van een NAND-latch **onvoorspelbaar** als de NAND-latch de transitie maakt van de aansturing AB = 00 naar de aansturing AB = 11?

  > antwoord

- Bepaal de **excitatietabel** van een NAND-latch a.d.h.v. de verkorte waarheidstabel

  > antwoord

**Gegeven**: het type bistabiel element is een **geklokte RS-latch**.

**Opgave**:

- Teken de **hardware** van de geklokte RS-latch, met inputs S, R en C en uitgangen Q en Q̅.

  > antwoord

- Bepaal de **verkorte waarheidstabel** van de geklokte RS-latch voor inputs S, R en Q<sub>tn</sub> en output Q<sub>tn+1</sub>

  > antwoord

- Bepaal de **excitatietabel** van een geklokte RS-latch a.d.h.v. de verkorte waarheidstabel.

  > antwoord

- Wanneer zijn de uitgangen **onvoorspelbaar**? Toon aan via een timing diagram.

  > antwoord

**Gegeven**: het type bitstabiel element is een geklokte D-latch.

**Opgave**:

- Teken de **hardware** van een geklokte D-latch, met inputs D en Cl en uitgangen Q en Q̅.

  > antwoord

- Bepaal de **verkorte waarheidstabel** van een geklokte D-latch voor inputs D en Q<sub>tn</sub> en uitgang Q<sub>tn+1</sub>

  > antwoord

- Bepaal de **excitatietabel** van een NAND-latch a.d.h.v. de verkorte waarheidstabel.

  > antwoord

- Waarom wordt dit een **D-latch** genoemd?

  > antwoord

**Gegeven**: het type bistabiel element is een Master-Slave JK-flipflop.

**Opgave**:

- Teken de **hardware** van de Master-Slave JK-flipflop, met inputs J, K en Cl en uitgangen Q en Q̅.

  > antwoord

- Bepaal de **verkorte waarheidstabel** van een Master-Slave JK-flipflop voor inputs J, K en Q<sub>tn</sub> en output Q<sub>tn+1</sub>

  > antwoord

- Bepaal de **excitatietabel** van een Master-Slave JK-flipflop a.d.h.v. de verkorte waarheidstabel.

  > antwoord

- Waarom wordt dit type flipflop een **Master-Slave** flipflop genoemd?

  > antwoord

- Hoe kan een Master-Slave flipflop als een **tweedeler** worden ingesteld?

  > antwoord

## Hoofdstuk 5: Registers

**Gegeven**: een 4-bit JK schuifregister

**Opgave**:

- Teken de **hardware** van een 4-bit schuifregister met JK-flipflops, met inputs Input, Clock en Reset.

  > antwoord

- Bepaal het **timingdiagram** van het 4-bit schuifregister met JK-flipflops.

  > antwoord

**Gegeven**: een 4-bit schuifregister (D-flipflops) met luswerking en mogelijkheid tot het laden van een input

**Opgave**:

- Teken de **hardware** van een 4-bit D-FF schuifregister met luswerking en mogelijkheid tot het laden van een input. De inputs zijn Input, Control en Klok.

  > antwoord

- Leg uit hoe deze schakeling werkt.

  > antwoord

**Gegeven**: een 4-bit JK schuifregister met mogelijkheid tot asynchroon, parallel laden

**Opgave**:

- Teken de **hardware** van een 4-bit schuifregister met JK-flipflops (inputs PE, Klok, Input, P<sub>1</sub>, P<sub>2</sub>, P<sub>3</sub> en P<sub>4</sub>).

  > antwoord

- Leg uit hoe deze schakeling werkt.

  > antwoord

**Gegeven**: een 4-bit JK schuifregister met mogelijkheid tot synchroon, parallel laden

**Opgave**:

- Teken de **hardware** van een 4-bit schuifregister met JK-flipflops (inputs PE, Input, Klok, Reset, P<sub>1</sub>, P<sub>2</sub>, P<sub>3</sub> en P<sub>4</sub>).

  > antwoord

- Leg uit hoe deze schakeling werkt.

  > antwoord

- Wat betekent **PISO** en hoe werkt dit?

  > antwoord

- Wat betekent **SIPO** en hoe werkt dit?

  > antwoord

## Hoofdstuk 6: Tellers

## Hoofdstuk 7: sequentiële systemen

**Gegeven**: de beschrijving van een sequentiedetector, Mealy of Moore, D-FF of JK-FF, met of zonder overlapping

**Opgave**:

- Teken de State Machine.

  > antwoord

- Bepaal de flip-flop uitgangen.

  > antwoord

- Bepaal de overgangstabel (present state, next state, present state output, …).

  > antwoord

- Vereenvoudig de overgangstabel door de redundante toestanden te elimineren d.m.v. een partitietabel.

  > antwoord

- Bepaal de vereenvoudigde hardware d.m.v. Karnaugh-kaarten.

  > antwoord

- Teken het hardware schema.

  > antwoord
