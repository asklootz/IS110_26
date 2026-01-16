// Alle øvelser vil ligge i sin egen metode https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
// For å kjøre metoden for de forskjellige øvelsene kan er det å gjøre delene på linje 30, 56, 78 og 86 til kjørbar kode fra kommentar
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 1: Deklarerer to variabler med meningsfulle navn og tilpassende datatyper.
            // Gjennomfør +, -, * og / operasjoner på de to variablene og legg resultatet i en variabel. Skriv ut resultatet.
            void oppg1()
            {
                // Deklarering av variabler
                int x = 20;
                int y = 5;
                
                // Utforming av mattematiske operasjoner og lagring av i nye variabler
                int pluss = x + y;
                int minus = x + y;
                int gange = x * y;
                int dele = x / y;
                
                // Skrive ut resultatene fra mattematiske operasjoner.
                Console.WriteLine("pluss: " + pluss);
                Console.WriteLine("minus: " + minus);
                Console.WriteLine("gange: " + gange);
                Console.WriteLine("dele: " + dele);
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg1();


            // Øvelse 2: Deklarerer en variabel av type heltall og skriver ut "arbeidsdag" hvis verdien til variabelen er fra 1 til 5 eller "helg" hvis verdien til variabelen er 6 og 7.
            // Koden skal skrive ut "ugyldig" hvis verdien er noe annen enn 1 - 7.
            void oppg2()
            {
                // Deklarering av variabel mellom 1 og 7 som sier dag
                int dagsnummer = 6;
                
                // Bruk av else-if funksjon for å printe hvilken dag det er
                if (dagsnummer >= 1 && dagsnummer <= 5) // Sier hvis "dagsnummer" er "1 eller større" og "5 eller mindre" printer den "Arbeidsdag"
                {
                    Console.WriteLine("Arbeidsdag");
                }
                else if (dagsnummer == 6 || dagsnummer == 7) // Sier hvis "dagsnummer" er 6 eller 7 printer den "Helg"
                {
                    Console.WriteLine("Helg");
                }
                else
                {
                    Console.WriteLine("Ugyldig");
                }

            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg2();


            // Øvelse 3: Deklarerer to variabler av type heltall.
            // Gi verdi til hver variabel og skriv kode som sjekker hvilket tall som har høyere verdi og skriver ut det tallet med verdi som er høyere enn det andre.
            // Ellers skriv ut at tallene er like.
            void oppg3()
            {
                // Deklarering av to variabler som skal sammenlignes 
                int j = 29;
                int i = 20;
                
                if (j == i) // Sjekker om variablene er like
                {
                    Console.WriteLine("Tallene er like");
                }
                else
                {
                    Console.WriteLine($"Største tallet er: {Math.Max(i, j)}"); // Bruker Math.Max funksjonen for å returnere den støreste verdien https://learn.microsoft.com/en-us/dotnet/api/system.math.max?view=net-10.0
                }
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg3();


            // Øvelse 4: Deklarerer en klasse og kaller den "Person". Deklarer variabler ID, navn, fødselsdato og adresse. Skriv en metode som skriver ut informasjon om person.
            // Oppretter et objekt med navn "nyPerson" fra klassen "Person"
            Person nyPerson = new Person();
            
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //nyPerson.Info();
        }
    }

    class Person // Deklarering av ny klasse "Person"
    {
        // Deklarerer variabler med fast informasjon om personen.
        private int ID = 12345;
        private string navn = "Ola Nordmann";
        private string fødselsdato = "12.01.2026";
        private string adresse = "Kongens Gate 1";

        // Oppretter konstruktøren for klassen for å kunne lage nye objekter
        public Person()
        {
            // Constructor
        }

        // Metode for å kunne skrive ut deklarer informasjon
        private void Info()
        {
            Console.WriteLine($"ID: {ID} \nNavn: {navn} \nFødselsdato: {fødselsdato} \nAdresse: {adresse}");
        }
    }
}
