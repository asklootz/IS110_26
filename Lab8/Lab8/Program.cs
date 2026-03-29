using System.Globalization;

namespace Lab8
{
 class Program
    {
        static void Main(string[] args) //: IBetalbar, IKvittering
        {
            List<IKvittering> kvittering = new List<IKvittering>();
            List<IBetalbar> betalbare = new List<IBetalbar>();

            while (true)
            {
                Console.WriteLine("1. Kino billett\n" +
                                  "2. Abonnement\n" +
                                  "3. Pizza\n" +
                                  "4. Skriv ut kvitteringer\n" +
                                  "0. Avslutt");
                Console.Write("Velg:");
                string menyValg = Console.ReadLine() ?? string.Empty;
                switch (menyValg)
                {
                    case "1":
                        Console.WriteLine("1. Kino billett");
                        Console.Write("Filmnavn:");
                        string filmnavn = Console.ReadLine();
                        Console.Write("Er det (1)voksen, (2)barn eller (3)student?: ");
                        int billettType = int.Parse(Console.ReadLine());
                        Console.Write("Antall: ");
                        int antall = int.Parse(Console.ReadLine());
                        
                            kvittering.Add(new KinoBillett ( filmnavn, billettType, antall));
                            betalbare.Add(new KinoBillett ( filmnavn, billettType, antall));
                        break;
                    case "2":
                        Console.WriteLine("2. Abonnement");
                        Console.Write("Navn på abonnement: ");
                        string navn = Console.ReadLine();
                        Console.Write("Varighet i måneder: ");
                        uint måneder = uint.Parse(Console.ReadLine());
                        Console.Write("Månedspris: ");
                        double månedsPris = double.Parse(Console.ReadLine());
                        
                        kvittering.Add(new Abonnement(navn, måneder, månedsPris)); 
                        betalbare.Add(new Abonnement(navn, måneder, månedsPris));
                        break;
                    case "3":
                        Console.WriteLine("3. Pizza");
                        Console.Write("Er det (1) Margherita (199kr), (2)Skinke (249kr) eller (3)Annen (300kr)?: ");
                        uint pizzaValg = uint.Parse(Console.ReadLine());
                        Console.Write("Antall: ");
                        uint pizzaAntall =  uint.Parse(Console.ReadLine());
                        kvittering.Add(new Pizza(pizzaValg, pizzaAntall));
                        betalbare.Add(new Pizza(pizzaValg, pizzaAntall));
                        
                        break;
                    case "4":
                        int num = 1;
                        foreach (var i in kvittering)
                        {
                            Console.Write($"{num++}. ");
                            i.SkrivKvitterin();
                        }

                        Console.WriteLine("\nTotal pris: " + betalbare.Sum(b => b.BeregnPris()).ToString("C", CultureInfo.CreateSpecificCulture("nb-NO")));
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.\n");
                        break;
                }
                
            }
        }
    }
}

