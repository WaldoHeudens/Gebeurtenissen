using Gebeurtenissen;

delegate void LogEventHandler(string Bericht);  // definieer het type van methode dat geassocieerd wordt met de gebeurtenis


class Program
{
    // een gebeurtenismethode die voldoet aan het gedefinieerde type
    public static void BerichtNaarOpzichter(string bericht)
    {
        Console.WriteLine("---> Opzichter hoorde: {0}", bericht);
    }

    // nog een gebeurtenismethode die voldoet aan het gedefinieerde type
    public static void BerichtNaarKlant(string bericht)
    {
        Console.WriteLine("---> De klant kreeg bericht: {0}", bericht);
    }

    static void Main(string[] args)
    {
        BouwerMetLog bouwer = new BouwerMetLog();
        object iets = new object();
        
        // Voeg aan de "Klaar"-gebeurtenis twee methoden toe
        bouwer.Klaar += new LogEventHandler(BerichtNaarOpzichter);
        bouwer.Klaar += new LogEventHandler(BerichtNaarKlant);

        bouwer.SchepZand(3);
        bouwer.PlaatsSchutting(5);
        // Haal één van de methoden weer weg van de "Klaar"-gebeurtenis
        bouwer.Klaar -= new LogEventHandler(BerichtNaarKlant);
        bouwer.PintjePakken();
    }
}