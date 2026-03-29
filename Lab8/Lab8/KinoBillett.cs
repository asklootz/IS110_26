using System.Globalization;
using System.Reflection.Metadata;

namespace Lab8;

public class KinoBillett : IBetalbar, IKvittering
{
    public string Film { get; set; }
    public double Pris { get; set; } = 299.90;
    public int BillettType { get; set; }
    public int Antall { get; set; }
    public double TotalPris { get; init; }
    
    public KinoBillett(string film, int billettType, int antall)
    {
        Film = film;
        BillettType = billettType;
        Antall = antall;
        TotalPris = BeregnPris();
    }

    public double BeregnPris()
    {
        double totalPris = Pris * Antall;
        if (BillettType == 2)
        {
            totalPris *= 0.5; // 50% rabatt for barn
        }
        else if (BillettType == 3)
        {
            totalPris *= 0.75; // 25% rabatt for voksne
        }
        return totalPris;
    }
    public void SkrivKvitterin()
    {
        Console.WriteLine($"Film: {Film}, Billettype: {(BillettType switch { 1 => "Voksen", 2 => "Barn", 3 => "Student" })} Antall: {Antall.ToString()}, Pris: {TotalPris.ToString("C", CultureInfo.CreateSpecificCulture("nb-NO"))}");
    }
}