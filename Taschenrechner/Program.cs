using System.Globalization;

Console.WriteLine("Willkommen beim Taschenrechner");

bool weiterRechnen = true;

double zahl1;
double zahl2;

while (weiterRechnen)
{
    try
    {
        Console.WriteLine("Bitte gib die erste Zahl ein");
        zahl1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Gib die zweite Zahl ein");
        zahl2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Wähle eine rechenart: + - * /");
        string operation = Console.ReadLine();

        double ergebnis = 0;
        bool gueltig = true;
    
        switch (operation)
        {
            case "+":
                ergebnis = addition(zahl1, zahl2);
                break;
            case "-":
                ergebnis = zahl1 - zahl2;
                break;
            case "*":
                ergebnis = zahl1 * zahl2;
                break;
            case "/":
                if (zahl2 == 0)
                {
                    Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt!");
                    gueltig = false;
                    break;
                }
                ergebnis = zahl1 / zahl2;
                break;
            default:
                Console.WriteLine("Ungültige Rechenart!");
                gueltig = false;
                break;
        }
    
        if (gueltig)
        {
            Console.WriteLine($"Ergebnis: {ergebnis}");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Fehler: Bitte gib nur gültige Zahlen ein!");
    }
    
    Console.WriteLine("Nochmal rechnen? (j/n");
    string antwort = Console.ReadLine();
    weiterRechnen = antwort == "j";
}

Console.WriteLine("Danke fürs Rechnen, bis bald!");

double addition(double zahl1, double zahl2)
{
    return zahl1 + zahl2;
}
