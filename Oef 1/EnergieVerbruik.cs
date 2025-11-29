using System;
using System.Collections.Generic;
using System.Text;

namespace Oef_1
{

    internal class EnergieVerbruik
    {
        private double vermogenInWatt;
        private double urenPerDag;
        private double prijsPerKWh;

        public double VermogenInWatt
        {
            get { return vermogenInWatt; }
            set
            {
                if (value < 0)
                {
                    vermogenInWatt = 0;
                    Console.WriteLine("Het vermogen kan niet negatief zijn. Het is ingesteld op 0 Watt.");
                }
                else
                {
                    vermogenInWatt = value;
                }
            }
        }

        public double UrenPerDag
        {
            get { return urenPerDag; }
            set
            {
                if (value < 0)
                {
                    urenPerDag = 0;
                    Console.WriteLine("Het aantal uren kan niet negatief zijn. Het is ingesteld op 0 uur.");
                }
                else if (value > 24)
                {
                    urenPerDag = 24;
                    Console.WriteLine("Het aantal uren kan niet meer dan 24 zijn. Het is ingesteld op 24 uur.");
                }
                else
                {
                    urenPerDag = value;
                }
            }
        }

        public double PrijsPerKWh
        {
            get { return prijsPerKWh; }
            set
            {
                if (value < 0)
                {
                    prijsPerKWh = 0;
                    Console.WriteLine("De prijs per kWh kan niet negatief zijn. Het is ingesteld op €0.");
                }
                else
                {
                    prijsPerKWh = value;
                }
            }
        }

        public double VerbruikPerDagInKWh
        {
            get { return (vermogenInWatt / 1000) * urenPerDag; }
        }
        public double VerbruikPerMaandInKWh
        {
            get { return VerbruikPerDagInKWh * 30; }
        }
        public double VerbruikPerJaarInKWh
        {
            get { return VerbruikPerDagInKWh * 365; }
        }
        public double KostenPerDag
        {
            get { return VerbruikPerDagInKWh * prijsPerKWh; }
        }
        public double KostenPerMaand
        {
            get { return VerbruikPerMaandInKWh * prijsPerKWh; }
        }
        public double KostenPerJaar
        {
            get { return VerbruikPerJaarInKWh * prijsPerKWh; }
        }
        public void Printoverzicht()
        {
            ToonOverzicht(VerbruikPerDagInKWh, VerbruikPerMaandInKWh, VerbruikPerJaarInKWh,
                KostenPerDag, KostenPerMaand, KostenPerJaar);
        }
        private static void ToonOverzicht(double verbruikPerDagInKWh, double verbruikPerMaandInKWh, double verbruikPerJaarInKWh,
            double kosterPerDag, double kosterPerMaand, double kosterPerJaar)
        {
            Console.WriteLine("\nOverzicht van het energieverbruik en de kosten:");
            Console.WriteLine($"Verbruik per dag: {verbruikPerDagInKWh} kWh, Kosten: {kosterPerDag} euro.");
            Console.WriteLine($"Verbruik per maand: {verbruikPerMaandInKWh} kWh, Kosten: {kosterPerMaand} euro.");
            Console.WriteLine($"Verbruik per jaar: {verbruikPerJaarInKWh} kWh, Kosten: {kosterPerJaar} euro.");
        }
    }
}
