using System;
using System.Collections.Generic;
using System.Text;

namespace Oef_2
{
    internal class Waterverbruik
    {
        private double litersPerBeurt;
        private double beurtenPerDag;
        private double prijsPerLiter;

        public double LitersPerBeurt
        {
            get { return litersPerBeurt; }
            set
            {
                if (value < 0)
                {
                    litersPerBeurt = 0;
                    Console.WriteLine("Het aantal liters kan niet negatief zijn. Het is ingesteld op 0 liter.");
                }
                else
                {
                    litersPerBeurt = value;
                }
            }
        }

        public double BeurtenPerDag
        {
            get { return beurtenPerDag; }
            set
            {
                if (value < 0)
                {
                    beurtenPerDag = 0;
                    Console.WriteLine("Het aantal beurten kan niet negatief zijn. Het is ingesteld op 0 beurten.");
                }
                else if (value > 100)
                {
                    beurtenPerDag = 100;
                    Console.WriteLine("Het aantal beurten kan niet meer dan 100 zijn. Het is ingesteld op 100 beurten.");
                }
                else
                {
                    beurtenPerDag = value;
                }
            }
        }

        public double PrijsPerLiter
        {
            get { return prijsPerLiter; }
            set
            {
                if (value < 0)
                {
                    prijsPerLiter = 0;
                    Console.WriteLine("De prijs per liter kan niet negatief zijn. Het is ingesteld op 0.");
                }
                else
                {
                    prijsPerLiter = value;
                }
            }
        }

        public double DagVerbruikInLiter
        {
            get { return litersPerBeurt * beurtenPerDag; }
        }
        public double MaandVerbruikInLiter
        {
            get { return DagVerbruikInLiter * 30; }
        }
        public double JaarVerbruikInLiter
        {
            get { return DagVerbruikInLiter * 365; }

        }
        public double KostenPerDag
        {
            get { return DagVerbruikInLiter * prijsPerLiter; }
        }
        public double KostenPerMaand
        {
            get { return MaandVerbruikInLiter * prijsPerLiter; }
        }
        public double KostenPerJaar
        {
            get { return JaarVerbruikInLiter * prijsPerLiter; }
        }
        public void Print()
        {
            PrintOverzicht(DagVerbruikInLiter, MaandVerbruikInLiter, JaarVerbruikInLiter,
                KostenPerDag, KostenPerMaand, KostenPerJaar);
        }
        public void PrintOverzicht(double verbruikPerDagInLiter, double verbruikPerMaandInLiter, double verbruikPerJaarInLiter,
            double kostenPerDag, double kostenPerMaand, double kostenPerJaar)
        {
            Console.WriteLine("Waterverbruik en kosten overzicht:");
            Console.WriteLine($"Dagelijks verbruik: {verbruikPerDagInLiter} liter, Kosten: {kostenPerDag} euro.");
            Console.WriteLine($"Maandelijks verbruik: {verbruikPerMaandInLiter} liter, Kosten: {kostenPerMaand} euro.");
            Console.WriteLine($"Jaarlijks verbruik: {verbruikPerJaarInLiter} liter, Kosten: {kostenPerJaar}  euro.");
        }
    }
}
