using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_3__met_Junior_
{
    
    public class Rechthoeken
    {
        public double diagonaal;
        public double oppervlakte;
        public double omtrek;
        public double verhouding;
        public double h;
        public double b;

        public double hoogte
        {
            get { return h; }
            set { h = value; }
        }
        public double breedte
        {
            get { return b; }
            set { b = value; }
        }

        public double Diagonaal()
        {
            diagonaal = Math.Sqrt((h * h) + (b * b));
            return diagonaal;
        }
        public double Oppervlakte()
        {
            oppervlakte = h * b;
            return oppervlakte;
        }
        public double Omtrek()
        {
            omtrek = 2 * (h + b);
            return omtrek;
        }
        public double Verhouding()
        {
            verhouding = h / b;
            return verhouding;
        }

        public void PrintBerekeningen()
        {
            Console.WriteLine("De diagonaal is: " + Diagonaal());
            Console.WriteLine("De oppervlakte is: " + Oppervlakte());
            Console.WriteLine("De omtrek is: " + Omtrek());
            Console.WriteLine("De verhouding is: " + Verhouding());
        }

    }
}
