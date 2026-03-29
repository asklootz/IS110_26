using System.Globalization;

namespace Lab8;

public class Pizza : IBetalbar, IKvittering
{
    public uint PizzaType  { get; init; }
    public string PizzaName { get; init; }
    public uint Antall { get; init; }
    public double Pris { get; init; }
    public double Totalpris { get; init; }

    public Pizza(uint pizzaType, uint antall)
    {
        PizzaType = pizzaType;
        PizzaName = SetPizzaNavn(pizzaType);
        Antall = antall;
        Pris = PizzaPris(pizzaType);
        Totalpris = BeregnPris();
    }

    string SetPizzaNavn(uint pizzaType)
    {
        if (pizzaType == 1)
        {
            return "Margherita";
        }

        if (pizzaType == 2)
        {
            return "Skinke";
        }

        return "Annen";
    }

    double PizzaPris(uint pizzaType)
    {
        if (pizzaType == 1)
        {
            return 199;
        }

        if (pizzaType == 2)
        {
            return 249;
        }

        return 300;
    }

    public double BeregnPris()
    {
        double totalPris = Pris * Antall;
        return totalPris;
    }

    public void SkrivKvitterin()
    {
        Console.WriteLine($"Pizza: {PizzaName}, Antall: {Antall.ToString()}, Pris: {Totalpris.ToString("C", CultureInfo.CreateSpecificCulture("nb-NO"))}");
    }
}
    
