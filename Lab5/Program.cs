// Alle øvelser vil ligge i sin egen metode https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
// Husk at dette er et forslag, har du noe som virker som ikke 100% ser ut som min kode betyr ikke det den er feil :D

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metoden under vil automatisk la deg velge å kjøre en av øvelsene i dette løsningsforslaget
            // Ønsker du å manuelt velgem kan du gjøre metoden til en kommentar og manuelt gjøre om de forskjellige til kode fra kommentar (på linje: 35, 144, 231)
            oppgValg();
            
            /*
             Øvelse 1:
            Opprette et array av type in med minst 10 tall
            Bruk en for-løkke til å:
                Skrive ut alle tallene
                Beregene summen av tallene
            Bruke en foreach-løkke til å:
                Finne det største tallet i arrayen
            */
            void oppg1()
            {
                int sum = 0;
                int[] arrayOppg1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int i = 0; i < arrayOppg1.Length; i++)
                {
                    sum = sum + arrayOppg1[i];
                    Console.WriteLine(arrayOppg1[i]);

                }

                Console.WriteLine($"Sum: {sum}");

                int max = arrayOppg1[0];
                foreach (int num in arrayOppg1)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }

                Console.WriteLine($"Største tallet: {max}");
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg1();


            //Øvelse 2
            void oppg2()
            {
                //Del 2: Opprett en List av type Product med minst 10 produkter (Legg inn 10 produkter)
                List<Product> produkter = new List<Product>(); //Oppretter listen
                produkter.Add(new Product(1, "Melk", "Meieri", 26.50m)); //Datatypen "decimal" skal settes med en "m" eller "M" på slutten av verdien https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
                produkter.Add(new Product(2, "Smør", "Meieri", 20.90m));
                produkter.Add(new Product(3, "Ost", "Meieri", 79.90m));
                produkter.Add(new Product(4, "Skolebolle", "Småbakst", 20.49m));
                produkter.Add(new Product(5, "Donut", "Småbakst", 22.50m));
                produkter.Add(new Product(6, "Cookie", "Småbakst", 12.50m));
                produkter.Add(new Product(7, "Eple", "Frukt", 5.30m));
                produkter.Add(new Product(8, "Banan", "Frukt", 3.69m));
                produkter.Add(new Product(9, "Kiwi", "Frukt", 4.20m));
                produkter.Add(new Product(10, "Kjøttdeig", "Kjøtt", 5.50m));

                // Del 3: Finne alle produkter i en bestemt kategori
                Console.Clear();
                Console.WriteLine("Finne alle produkter i en bestemt kategori:");
                Console.Write("Kategori: ");
                string kategori = Console.ReadLine();
                
                // En måte å gjøre dette på via lambda expression
                produkter.Where(p => p.category == kategori)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"ID: {p.id}, Navn: {p.name}, Kategori: {p.category}, Pris:  {p.price}")); //LINQ skrevet i lambda https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
                //Kan også skrives slik som den er skrevet under
                //produkter.Where(p => p.category == kategori).ToList().ForEach(p => Console.WriteLine($"ID: {p.id}, Navn: {p.name}, Kategori: {p.category}, Pris:  {p.price}"));

                //Samme løsning skrevet i mer tradisjonell LINQ under
                
                var valgtKategori =
                    from produkt in produkter
                    where produkt.category == kategori
                        select (produkt.id, produkt.name,  produkt.category,  produkt.price);

                foreach (var i in valgtKategori)
                {
                    Console.WriteLine($"ID: {i.id}, Navn: {i.name}, Kategori: {i.category}, Pris:  {i.price}");
                }
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 
                
                
                // Del 3: Finne alle produkter med pris mellom to verdier (brukeren skriver min/max)
                Console.WriteLine("Finne alle produkter med pris mellom to verdier (brukeren skriver min/max):");
                Console.Write("Min:");
                decimal min = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Max:");
                decimal max =  Convert.ToInt32(Console.ReadLine());
                
                // Under er lambda brukt https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
                /*produkter.Where(p => p.price >= min && p.price <= max)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"ID: {p.id}, Navn: {p.name}, Kategori: {p.category}, Pris:  {p.price}"));*/

                //Samme løsning skrevet i mer tradisjonell LINQ under
                var minMax =
                    from produkt in produkter
                    where produkt.price >= min && produkt.price <= max
                    select (produkt.id, produkt.name, produkt.category, produkt.price);

                foreach (var i in minMax)
                {
                    Console.WriteLine($"ID: {i.id}, Navn: {i.name}, Kategori: {i.category}, Pris:  {i.price}");
                }
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 
                
                
                // Del 3: Finne alle produkter som koster mer enn en gitt pris fra brukeren
                Console.WriteLine("Finne alle produkter som koster mer enn en gitt pris fra brukeren:");
                Console.Write("Større enn: ");
                decimal biggerThan = decimal.Parse(Console.ReadLine());
                
                // Under er lambda brukt https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
                /*
                produkter.Where(p => p.price > biggerThan)
                    .OrderBy(p => p.price)//Her sorterer vi etter stigende pris som skal gjøres i neste oppgave 
                    .ToList()
                    .ForEach(p => Console.WriteLine($"ID: {p.id}, Navn: {p.name}, Kategori: {p.category}, Pris: {p.price}"));*/
                
                //Samme løsning skrevet i mer tradisjonell LINQ under
                var størreEnn = 
                    from produkt in produkter 
                    where produkt.price > biggerThan
                    orderby produkt.price ascending, produkt.category 
                    select produkt;
                
                foreach (var i in størreEnn)
                {
                    Console.WriteLine($"ID: {i.id}, Navn: {i.name}, Kategori: {i.category}, Pris:  {i.price}");
                }
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 
                
                
                // Del 3: Sorter produkter etter pris stigende
                Console.WriteLine("Sorter produkter etter pris stigende:");
                produkter.OrderBy(p => p.price)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"ID: {p.id}, Navn: {p.name}, Kategori: {p.category}, Pris: {p.price}"));
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 
                

                // Del 3: Bruk LINQ til å organisere produkter i grupper basert på kategori og si antall
                var organisertKategori = produkter
                    .GroupBy(p => p.category) // Grupper etter kategori
                    .Select(g =>  new
                    {
                        Category = g.Key,
                        Count = g.Count() // Tell antall i hver kategori
                    })
                    .ToList();
                            

                Console.WriteLine("Bruk LINQ til å organisere produkter i grupper basert på kategori og si antall:");
                foreach (var i in organisertKategori)
                {
                    Console.WriteLine($"Category: {i.Category}, Count: {i.Count}");
                }
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 


                // Del 4: Skrive ut produktene pent formatert
                Console.WriteLine("Skrive ut produktene pent formatert:");
                foreach (var i in produkter)
                {
                    Console.WriteLine($"ID: {i.id}, Navn: {i.name}, Kategori: {i.category}, Pris:  {i.price}");
                }
                Console.WriteLine(""); // For å ha mellomrom mellom oppgaver 

                // Del 4: Beregne totalprisen for alle produktene
                Console.WriteLine("Beregne totalprisen for alle produktene:");
                decimal sum = 0;
                foreach (var i in produkter)
                {
                    sum += i.price;
                }
                Console.WriteLine($"Totalprisen av alle varer er: {sum}");
            }
            // Gjør linjen under til kjørbar kode fra kommentar med å slette skråstekene for å teste løsning
            //oppg2();


            void oppg3()
            {
                List<string> handleliste = new List<string>();

                while (true)
                {
                    Console.Write("Velkommen til handlelisten din! \n1. Legg til vare \n2. Fjern vare (bruk navn) \n3. Vis alle varer \n4. Vis varer sortert alfabetisk \n5. Søk etter varer som inneholder et søkeord \n6. Avslutt \nDitt valg: ");
                    string brukerSvar =  Console.ReadLine();

                    switch (brukerSvar)
                    {
                        case "1":
                            Console.Write("Navnet på varen du vil legge til: ");
                            string nyVare = Console.ReadLine();
                            handleliste.Add(nyVare);
                            
                            Console.Clear();
                            Console.WriteLine("Lagt til! :)\n");
                            break;

                        case "2":
                            Console.Write("Navnet på varen du vil fjerne: ");
                            string fjerneVare = Console.ReadLine();
                            if (handleliste.Contains(fjerneVare)) // Sjekke varen om den eksisterer
                            {
                                handleliste.Remove(fjerneVare); // Fjerner varen
                                Console.Clear();
                                Console.WriteLine("Fjernet! :) \n");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Denne varen finnes ikke :/ \n");
                            }
                            break;
                        
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Alle varer i lista:");
                            foreach (var i in handleliste)
                            {
                                Console.WriteLine(i);
                                
                            }
                            Console.WriteLine("");
                            break;
                        
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Alle varer i lista i alfabetisk rekkefølge:");
                            var alfabetiskListe = handleliste.OrderBy(p => p).ToList();
                            foreach (var i in alfabetiskListe)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("");
                            break;
                        
                        case "5":
                            Console.Clear();
                            Console.Write("Søkeord: ");
                            string søkeOrd =  Console.ReadLine();
                            List<string> resultater = handleliste
                                .Where(vare => vare.Contains(søkeOrd, StringComparison.OrdinalIgnoreCase)).ToList(); // Lager en liste av resultater som matcher søkeordet uten å kreve at det er stor eller liten bokstav https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
                           
                            Console.WriteLine($"Alle resultater med {søkeOrd} i:");
                            foreach (var i in resultater)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("");
                            break;
                        
                        case "6":
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
            //oppg3();
            
            
            void oppgValg()
            {
                while (true)
                {
                    Console.Write("Løsningsforslag for lab 4! Hvilken øvelse vil du prøve å kjøre? (1, 2, 3): ");
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
                        default:
                            Console.Clear();
                            Console.WriteLine("Du skrev ikke inn 1, 2, 3. Prøv igjen!\n");
                            break;
                    }
                }
            }
        }
    }
}