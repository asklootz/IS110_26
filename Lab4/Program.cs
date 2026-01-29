// Alle øvelser vil ligge i sin egen metode https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

// NB! Labøvelsene her handler hovedsaklig om å skrive kode riktig, er ikke alt som skal kjøres, så viktig å se "Klasser.cs" for å se hele løsninger
// Skal fortsatt ha eksempler på bruk på alle klasser og øvelser
namespace  Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			// Metoden under vil automatisk la deg velge å kjøre en av øvelsene i dette løsningsforslaget
			// Ønsker du å manuelt velgem kan du gjøre metoden til en kommentar og manuelt gjøre om de forskjellige til kode fra kommentar (på linje: 33, 52, 73, 92)
			oppgValg();
			
			/*
		    Øvelse 1: Lag en klasse som representerer en Book.
		    Klassen skal ha: Tittel, forfatter og utgivelseår
		    Bruke auto-implementerte egenskaper
		    Alle egenskapene skal være tilgjengelige utenfra klassen
		    Klassen skal kunne brukes fra Program.cs
		    */
			void oppg1()
			{
				Book nyBook = new Book(); // Oppretter nytt objekt av klassen "Book" i Program.cs
				
				nyBook.tittel = "Chainsaw Man Volume 1"; // Endrer tittel utenfor klassen ved bruk av "set" her og i de neste 2 linjene
				nyBook.forfatter = "Tatsuki Fujimoto";
				nyBook.utgivelseÅr = 2020;
				
				Console.WriteLine($"Boken {nyBook.tittel}, skrevet av {nyBook.forfatter}, kom ut {nyBook.utgivelseÅr}"); // Henter info om boken direkte via "get"
			}
			// Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
			//oppg1();
			
			
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
			void oppg2()
			{
				UserAccount nyBruker = new UserAccount("SuperBruker123", "HemmeligPassord15", DateOnly.FromDateTime(DateTime.Now));
				nyBruker.EndrePassord();
			}
			// Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
			//oppg2();

			
			/*
			Øvelse 3: Du jobber i et system som består av flere prosjekter. Lag en klasse ConfigurationManager som:
				Ikke skal være tilgjengelig fra andre prosjekter
				Har egenskaper for applikasjonsnavn og versjonsnummer
			Krav:
				Bruker "internal" der det er hensiktsmessig
				Bruk auto-implementerte egenskaper
				Klassen skal kunne brukes fritt innenfor samme prosjekt
			*/
			void oppg3()
			{
				// Viser at klassen kan fint bruker inni prosjekt "Lab4"
				ConfigurationManager nyConfig = new ConfigurationManager();
				nyConfig.applikasjonsNavn = "NetCat";
				nyConfig.versjonsNummer = "1.10";
				Console.WriteLine($"{nyConfig.applikasjonsNavn} er på versjon {nyConfig.versjonsNummer}");
			}
			// Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
			//oppg3();
			

			/*
		    Øvelse 4: Design en klasse Employee for et HR-system.
		    Klassen skal ha: Ansattnummer, navn og månedslønn
		    Krav:
		        Ansattnummer skal ikke kunne endres etter at objektet er opprettet
		        Månedslønn skal ikke kunne endres direkte utenfra klassen
		        Alle data skal være tilgjengelig for lesing der det er fornuftig
		        Bruk auto-implementerte egenskaper
			*/
			void oppg4()
			{
				Employee nyEmployee = new Employee(67, "Joeseph Joestar");
				nyEmployee.settLønn();
				
			}
			// Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
			//oppg4();
			
			
			void oppgValg()
			{
				while (true)
				{
					Console.Write("Løsningsforslag for lab 4! Hvilken øvelse vil du prøve å kjøre? (1, 2, 3, 4): ");
					int valgtOppg = int.TryParse(Console.ReadLine(), out int valg) ? valg : 0;

					switch (valgtOppg)
					{
						case 1:
							oppg1();
							return;
						case 2:
							oppg2();
							return;
						case 3:
							oppg3();
							return;
						case 4:
							oppg4();
							return;
						default:
							Console.Clear();
							Console.WriteLine("Du skrev ikke inn 1, 2, 3, eller 4. Prøv igjen!\n");
							break;
					}
				}
			}
		}
	}
};

