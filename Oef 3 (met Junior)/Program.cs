namespace Oef_3__met_Junior_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef mij de hoogte: ");
            double hoogte = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef mij de breedte: ");
            double breedte = Convert.ToDouble(Console.ReadLine());

            Afmetingen afmetingen = new Afmetingen();
            afmetingen.Hoogte = hoogte;
            afmetingen.Breedte = breedte;

            afmetingen.transit();

            Rechthoeken rechthoek = new Rechthoeken();

            rechthoek.PrintBerekeningen();

        }
    }
}
