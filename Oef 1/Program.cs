namespace Oef_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het vermogen van het toestel in Watt:");
            double vermogen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef het aantal uren dat het toestel per dag gebruikt wordt:");
            double uren = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef de prijs per kWh in euro:");
            double prijs = Convert.ToDouble(Console.ReadLine());

            EnergieVerbruik toestel = new EnergieVerbruik
            {
                VermogenInWatt = vermogen,
                UrenPerDag = uren,
                PrijsPerKWh = prijs
            };

            toestel.Printoverzicht();
        }
    }
}
