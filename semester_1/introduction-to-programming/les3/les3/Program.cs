byte ageOfPerson = 255;

Console.WriteLine("I am " + ageOfPerson + " years old.");

// integer
int price = 123;
int discount = -12;
int shippingCost = 0;

int amount = price + discount + shippingCost;
// Output to console
Console.WriteLine("De netto prijs is " + price);
Console.WriteLine("De korting is " + discount);
Console.WriteLine("De verzendingskosten zijn " + shippingCost);
Console.WriteLine("Het totaal te betalen bedrag is " + amount);

// Floating point
double energy;
energy = 123.45;
double energyPrice = 0.345;
double correction = -5.0;
Console.WriteLine("Er is " + energy + " kWh verbruikt");
Console.WriteLine("De kostprijs is " + energyPrice + "Euro/kWh");

// char & string 
char letter = 'A';
Console.WriteLine("Het alfabet begint bij de letter " + letter);
string sentence = "Introduction to Programming";
Console.WriteLine("Momenteel zit ik in de let " + sentence);


Console.WriteLine();

int input = 40;
char o = (char) input;
string output = o.ToString();
Console.WriteLine("Resultaat is: " + output);
Console.WriteLine("De lengte van het resultaat is " + output.Length + " karakters");

int diameter = 5;
double pi = Math.PI;
double surface = pi * diameter * diameter;
Console.WriteLine("Oppervlakte van de cirkel is " + surface);

double celsius = 20;
double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;
Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
Console.WriteLine($"{celsius}°C is equal to {kelvin}°K");