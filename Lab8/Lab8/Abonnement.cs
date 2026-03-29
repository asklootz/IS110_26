using System.Globalization;

namespace Lab8;

public class Abonnement : IBetalbar, IKvittering
{
   private readonly string navn;
   private readonly uint måneder;
   private readonly double månedsPris;

   public Abonnement(string navn, uint måneder, double månedsPris)
   {
      this.navn = navn;
      this.måneder = måneder;
      this.månedsPris = månedsPris;
   }

   public double BeregnPris()
   {
      return Math.Round((måneder * månedsPris), 2);
   }

   public void SkrivKvitterin()
   {
      Console.WriteLine($"Abonnement: {navn} Varighet: {måneder.ToString("C", CultureInfo.CreateSpecificCulture("nb-NO"))} Månedspris: {månedsPris} Totalpris: {BeregnPris().ToString("C", CultureInfo.CreateSpecificCulture("nb-NO"))}");
   }
}