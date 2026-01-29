// Ny fil for alle nødvendige klasser for forskjellige øvelser
// Ofte anbefalt å ha klasser i egne filer https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
// Dette er anbefalt i C# og i Java er det påbudt https://stackoverflow.com/questions/144783/c-sharp-classes-in-separate-files

namespace Lab4
{
    /*
    Øvelse 1: Lag en klasse som representerer en Book.
    Klassen skal ha: Tittel, forfatter og utgivelseår
    Krav:
        Bruke auto-implementerte egenskaper
        Alle egenskapene skal være tilgjengelige utenfra klassen
        Klassen skal kunne brukes fra Program.cs
    */
    // Klasse for Oppgave 1
    public class Book
    {   
        // Bruker autoimplementerte egenskaper og tilgangsmodifikatorer slik at egenskaper er tilgjengelig utenfor klassen
        public string tittel { get; set; } 
        public string forfatter { get; set; }
        public uint utgivelseÅr { get; set; }
        
        public Book()
        {
            // Konstruktør 
        }
    }
    
    
    /*
    Øvelse 2: Lag en klasse UserAccount som representerer en bruker i et system
    Klassen skal ha: Brukernavn, passord, data for opprettelse
    Krav:
        Bruk auto-implementerte egenskaper
        Bruk tilgangsmodifikator slik at:
            Brukernavn kan leses utenfra, men ikke endres
            Passord ikke kan leses eller endres direkte utenfra klassen
        Lag minst én metode som på en kontrollert måte endrer passordet.
    */
    // Klasse for Oppgave 2
    public class UserAccount
    {
        public string brukernavn { get; private set; } // Bruker autoimplimentering "private set;" slik at den kun kan endres via en metode fra klassen, ikke direkte. 
        private string passord { get; set; } // Bruker tilgangsmodifikator for å si at den kun kan endres å få bli hentet på innsiden av klassen ikke utenfra.
        public DateOnly opprettetDato { get; } // Dato for opprettelse har ingen krav så lar den være åpen for å hente, men ikke endres på.

        public UserAccount(string _brukernavn, string _passord, DateOnly _opprettetDato)
        {
            // Kontruktør
            // Setter verdi på egenskaper til klassen.
            brukernavn = _brukernavn;
            passord = _passord;
            opprettetDato = _opprettetDato;
        }

        // En metode for å endre passord på en kontrollert måte
        public void EndrePassord()
        {
            int forsøk = 1;
            while (true)
            {
                // Spør om gammelt passord først
                Console.Write("Gammelt passord: ");
                string gammeltPassord = Console.ReadLine();
                if (gammeltPassord == passord) //Sjekker at du skrev inn riktig gammelt passord
                {
                    Console.Write("Nytt passord: "); // Gir mulighet til å endre passord etter at riktig passsord ble skrevet inn
                    passord = Console.ReadLine();
                    Console.WriteLine($"Hurra! Passordet til {brukernavn} (opprettet: {opprettetDato}) er endret til {passord}!");
                    return;
                }
                else if (forsøk == 3) // Sjekker om det er brukt for mange forsøk, avslutter om det er feil 3 ganger
                {
                    Console.Clear();
                    Console.Write("For mange feil forsøk, avslutter!");
                    return;
                }
                else // Starter på nytt om feil passord er skrevet inn
                {
                    Console.Clear();
                    Console.WriteLine("Feil gammel passord, prøve igjen!\n");
                    forsøk++; //Øker antall forsøk brukt
                }
            }
        }
    }

    
    /*
    Øvelse 3: Du jobber i et system som består av flere prosjekter. Lag en klasse ConfigurationManager som:
        Ikke skal være tilgjengelig fra andre prosjekter
        Har egenskaper for applikasjonsnavn og versjonsnummer
    Krav:
        Bruker "internal" der det er hensiktsmessig
        Bruk auto-implementerte egenskaper
        Klassen skal kunne brukes fritt innenfor samme prosjekt
    */
    // Klasse for Oppgave 3
    // Bruker "internal" for å begrense klassen til "Lab4" -prosjektet. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal
    // Internal begrenser klassen slik at; f.eks. alle andre prosjekter i repository-et ikke kan nå det, så Lab3 kan bruke alle andre klasser uten om akkuratt denne. 
    internal class ConfigurationManager 
    {
        // Ingen spesielle krav om egenskaper så gjør dem tilgjengelige
        public string applikasjonsNavn { get; set; }
        public string versjonsNummer { get; set; }

        public ConfigurationManager()
        {
            // Kontruktør
        }
    }
    
    /*
    Øvelse 4: Design en klasse Employee for et HR-system.
    Klassen skal ha: Ansattnummer, navn og månedslønn
    Krav:
        Ansattnummer skal ikke kunne endres etter at objektet er opprettet
        Månedslønn skal ikke kunne endres direkte utenfra klassen
        Alle data skal være tilgjengelig for lesing der det er fornuftig 
        Bruk auto-implementerte egenskaper 
    */
    // Klasse for Oppgave 4
    class Employee
    {
        public uint ansattNummer { get; init;  } // Bruk av "init" sier at vi kun kan "set"-e verdi ved konstruksjon av nytt objekt https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init
        public string navn  { get; set; }
        private uint månedslønn { get; set; } // Månedslønn skal ikke kunne direkte endres utenfor klassen og trenger ikke å kunne hentes direkte utenfor klassen heller så dette kan være privat (må ikke)

        public Employee(uint _ansattNummer, string _navn)
        {
            // Konstruktør
            ansattNummer = _ansattNummer;
            navn = _navn;
        }

        // En metode for å sette lønn på ansatt
        public void settLønn()
        {
            while (true)
            {
                Console.Write("Ansatt nummer: ");
                uint ansattNum =  uint.Parse(Console.ReadLine());
                if (ansattNum == ansattNummer) // Sjekker at riktig ansattnummer er skrevet inn
                {
                    Console.Write($"Skrive lønn til {navn} ({ansattNummer}): ");
                    månedslønn = uint.Parse(Console.ReadLine());
                    Console.WriteLine($"Ny satt månedslønn til {navn} ({ansattNummer}) er: {månedslønn} kr i måneden.");
                    return;
                }
                else // Ved feil nummer starter man på nytt
                {
                    Console.Clear();
                    Console.WriteLine("Finner ikke noen med dette ansattenummeret prøv igjen:\n");
                }
            }
        }
    }

}