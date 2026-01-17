// Alle øvelser vil ligge i sin egen metode https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
// For 

using System.Diagnostics;
using System.Globalization;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 1:  Basert på programmet vi skrev sammen i forrige forelesningen,
            // så skal du utvide koden sånn at den tar inndata fra brukeren og lager så mange objekter av type person som brukeren vil til at brukeren gir beskjed "exit".
            // Da stopper applikasjonen ved "exit" beskjed og ender med å skrive ut en melding til brukeren som for eksempel "slutt!" eller noe lignende.
            void oppg1()
            {
                // Basert på beskrivelsen skal vi ta inndate fra en bruker for å kunne lage uendelig med personer. Da må vi opprette en måte for brukeren å ha en dialog med programmet
                
                while (true) // Setter en switch-case i en uendelig loop som kun stopper om man skriver "exit"
                {
                    Console.Write("Velkommen! \nSkriv 'ny' for å lage ny person \nSkriv 'exit' for å avslutte programmet \nSkriv 'vis' for å se alle personene \nSvar: ");
                    string brukerSvar = Console.ReadLine();
                    
                    switch (brukerSvar) // Bruker switch-statement for å lettere velge hva som skal gjøres basert på inndata https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement
                    {
                        case "ny": 
                            Console.Clear(); // Console.Clear selvforklarende fjerner all tidligere tekst  fra

                            // Deklarerer variabel som brukes til ID-nummer 
                            Console.Write("ID nummer: ");
                            uint _id = uint.Parse(Console.ReadLine());
                            
                            // Deklarerer variabel som brukes til navn
                            Console.Write("Navn: ");
                            string _navn = Console.ReadLine();
                            
                            // Deklarerer variabel som brukes til fødselsdato
                            Console.Write("Fødselsdato (dd.mm.yyyy): ");
                            DateOnly _fødselsdato = DateOnly.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture); // Bruker "ParseExact" for å si at vi skal bruke spesifisert format og om vi evt følger kulturelle dato format https://learn.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-10.0 og https://learn.microsoft.com/en-us/dotnet/api/system.iformatprovider?view=net-10.0
                            
                            // Deklarerer variabel som brukes til adresse
                            Console.Write("Adresse: ");
                            string _adresse = Console.ReadLine();
                            
                            // Oppretter nytt objekt fra klassen med variabler fra bruker
                            Person nyPerson = new Person(_id, _navn, _fødselsdato, _adresse);
                            nyPerson.Info(); // Viser det person-objektet. 
                            break;
                        
                        case "exit":
                            Console.WriteLine("Slutt!");
                            return; //Avslutter loop og programmet
                        
                        default:
                            Console.Clear();
                            Console.WriteLine("Ugylid, prøv igjen\n");
                            break;
                    }
                }


            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg1();
            
            
            // Øvelse 2: Basert på øvelse 1 i Lab øvelse 2, så skal du opprette en klasse og kalle den "MatteKlasse". Opprett metoder for hver matte operasjon.
            // Opprett et objekt av klassen i Program.cs og utvid koden sånn at den tar inn verdiene av tallene og operasjonen fra brukeren.
            // Kall metodene på objektet basert på operasjonen som brukeren gir til programmet.
            void oppg2()
            {
                MatteKlasse nyMatte = new MatteKlasse();
                nyMatte.kalkulator();
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg2();
            
            
            // Øvelse 3: Skriv en kode som tar inn en integer (heltall) verdi fra brukeren og sjekker om tallet er oddetall eller partall. Koden skal skrive ut en melding til brukeren at tallet er oddetall eller partall. 
            void oppg3()
            {
                // Denne oppgaven er veldig lik et mattematisk spill som heter "FizzBuzz", anbefaler alle å prøve det ut, veldig god trenging for å lære seg grunnleggende på nytt programmeringsspråk 
                // https://www.geeksforgeeks.org/dsa/fizz-buzz-implementation/

                Console.Write("Nummer: ");
                int nummer = int.Parse(Console.ReadLine());
                if (nummer % 2 == 0) // Bruker % som vil sjekke hva gjenværende er når vi deler på et annet tall. Har sjekker vi om det er 0 gjenværende når vi deler på 2 for å sjekke partall https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-
                {
                    Console.Write($"Nummeret {nummer} er et partall");
                }
                else
                {
                    Console.Write($"Nummeret {nummer} er et oddetall");
                }
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg3();
            
            /*
             Øvelse 4: .Opprett en klasse og kall den "Student" som et institutt kan bruke til å representere informasjon som instansvariabler: studentId (type string), studentNavn (type string) og tre separate variabler for poengsummer i tre fag (type decimal). 
             Klassen din bør ha en konstruktør som initialiserer de fem verdiene. 
             Opprett Set og Get metoder for alle instansvariabler. Oprett også metoder "GetAggregate()" og "GetPercentage()" som beregner de samlede poengsummene i de tre fagene (summen av tre fagpoengsummer) og prosentandelen (dvs. sum delt på maksimumspoengsummen, 60, og deretter multiplisert med 100), og returner deretter aggregatet og prosentandelen som desimalverdi. 
             Skriv en kode i Program.cs som demonstrerer klassens Student-evner.
             */
            void oppg4()
            {
                // Maks poengsum på 3 fag er 60 så antar at det er maks 20 poeng per fag
                
                Console.Write("Studentens ID: ");
                string _studentId = Console.ReadLine();
                
                Console.Write("Studentens navn: ");
                string _studentNavn = Console.ReadLine();

                Console.Write("Karakterpoeng i faget IS105 (1-20): ");
                decimal _is105 = decimal.Parse(Console.ReadLine());

                Console.Write("Karakterpoeng i faget IS110 (1-20): ");
                decimal _is110 = decimal.Parse(Console.ReadLine());

                Console.Write("Karakterpoeng i faget IS114 (1-20): ");
                decimal _is114 = decimal.Parse(Console.ReadLine());

                Student nyStudent = new Student(_studentId, _studentNavn, _is105, _is110, _is114);

                nyStudent.StudentInfo();
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            oppg4();
        }
        
        // Oppgave 1 klasse
        // Copy/Paste kode fra forrige oppgave og endrer på variabler og konstruktør. (Copy/Paste, aka det alle som programmerer kan best 😁)
        class Person // Deklarering av ny klasse "Person"
        {
            // Deklarerer variabler med fast informasjon om personen
            private uint id {get;} // "get" vil gjøre at vi kan hente ut variabel utenfor klassen. Vi har ikke "set" siden dette er en "private" variabel => Du kan sette "private set", men ikke nødvendig siden den er satt til det automatisk
            private string navn {get;}
            private DateOnly fødselsdato {get;}
            private string adresse {get;}

            // Oppretter konstruktøren for klassen for å kunne lage nye objekter
            // Kontruktøren tar inn varablene fra brukeren og setter dem på det nye objektet. 
            public Person(uint _id, string _navn, DateOnly _fødselsdato, string _adresse)
            {
                id = _id;
                navn = _navn;
                fødselsdato = _fødselsdato;
                adresse = _adresse;
            }

            // Metode for å kunne skrive ut deklarert informasjon og vise at objektet er opprettet
            public void Info()
            {
                Console.WriteLine("Nyeste opprettet objekt:");
                Console.WriteLine($"ID: {id} \nNavn: {navn} \nFødselsdato: {fødselsdato} \nAdresse: {adresse}\n");
            }
        }
        
        // Oppgave 2 klasse
        class MatteKlasse
        {
            private float num1; // Bruker variabel typen "float" for å kunne ta i bruk desimaler, kan og bruke "double" eller "decimal" https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            private float num2; 
            private string operatør;

            public MatteKlasse()
            {
                // Konstruktør
            }

            // Følger oppgavens krav om å lage en metode for hver operasjon, pluss, minus, multiplikasjon og divisjon
            private void pluss()
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }

            private void minus()
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }

            private void ganging()
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }

            private void deling()
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            
            // Mettode for å ta inndata fra bruker og utføre regning
            public void kalkulator()
            {
                
                while (true)
                {
                    Console.Write("Første nummmer: "); 
                    num1 = float.Parse(Console.ReadLine());
                    
                    Console.Write("Operatør (x, -, *, /): "); 
                    operatør = Console.ReadLine();
                    
                    Console.Write("Andre nummmer: "); 
                    num2 = float.Parse(Console.ReadLine());
                                 
                    switch (operatør) // Switch som vil avslutte programmet etter regning er utført. 
                    {
                        case "+":
                            pluss();
                            return;
                        case "-":
                            minus();
                            return;
                        case "*":
                            ganging();
                            return;
                        case "/":
                            deling();
                            return;
                        default: // Hvis feil blir gjort så skal metoden starte på nytt. 
                            Console.Clear();
                            Console.WriteLine("Ugyldig operatør, prøv igjen: \n");
                            break;
                    }
                }
            }
        }
        
        // Øvelse 4 klasse
        class Student
        {
            private string studentId { get; set; }

            private string studentNavn { get; set;  }
            private decimal IS110 { get; set; }
            private decimal IS105 { get; set; }
            private decimal IS114  { get; set; }

            public Student(string _studentId, string _studentNavn, decimal _is105, decimal _is110, decimal _is114)
            {
                studentId = _studentId;
                studentNavn = _studentNavn;
                IS105 = _is105;
                IS110 = _is110;
                IS114 = _is114;
            }

            private decimal GetAggregate() // Vi bruker "decimal" istedenfor "void" for at metoden skal returnere en decimal verdi => "void" betyr bare at den ikke skal returnere noe https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#return-values
            {
                return IS105 + IS110 + IS114;
            }

            private decimal GetPercentage()
            {
                return GetAggregate() / 60 * 100;
            }

            public void StudentInfo()
            {
                Console.WriteLine($"Studentens ID: {studentId}");
                Console.WriteLine($"Studentens navn: {studentNavn}");
                Console.WriteLine($"Karakterpoeng i faget IS105: {IS105}");
                Console.WriteLine($"Karakterpoeng i faget IS110: {IS110}");
                Console.WriteLine($"Karakterpoeng i faget IS114: {IS114}");
                Console.WriteLine($"Total poengsum i alle fag: {GetAggregate()}"); // Bruker returnert verdi for å regne ut
                Console.WriteLine($"Prosentdel av 100% for alle fagene sammen: {GetPercentage()}");
            }
        }
    }
}

