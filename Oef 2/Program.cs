namespace Oef_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel liter verbruikt het toestel per beurt?");
            double liters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hoeveel beurten per dag wordt het toestel gebruikt?");
            double beurten = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is de prijs per liter?");
            double prijsPerLiter = Convert.ToDouble(Console.ReadLine());

            Waterverbruik waterverbruik = new Waterverbruik();
            waterverbruik.LitersPerBeurt = liters;
            waterverbruik.BeurtenPerDag = beurten;
            waterverbruik.PrijsPerLiter = prijsPerLiter;

            waterverbruik.Print();
        }
    }
}
