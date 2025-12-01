using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_3__met_Junior_
{
    public class Afmetingen
    {
        private double hoogte;
        private double breedte;
        public double Hoogte
        {
           get { return hoogte; }
            set
            {
                if (value < 1)
                {
                    hoogte = 1;
                    Console.WriteLine("De hoogte kan niet kleiner dan 1 zijn. Het is ingesteld op 1.");
                }
                else
                {
                    hoogte = value;
                }
            }
        }
        
        public double Breedte
            {
            get { return breedte; }
            set
            {
                if (value < 1)
                {
                    breedte = 1;
                    Console.WriteLine("De breedte kan niet kleiner dan 1 zijn. Het is ingesteld op 1.");
                }
                else
                {
                    breedte = value;
                }
            }
            
        }

        public void transit()
        {
            Rechthoeken rechthoek = new Rechthoeken();
            rechthoek.h = hoogte;
            rechthoek.b = breedte;
        }


    }


}
