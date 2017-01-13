using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.02 / 100; //kulutus per kilometri
            double hinta = 1.595; //per litra
            int matka;
            Console.Write("Anna matka(km): ");
            matka = Int32.Parse(Console.ReadLine());
            double lopullinen = kulutus * matka;
            double kustannus = lopullinen * hinta;
            Console.WriteLine("Bensaa kuluu " + (lopullinen.ToString("N2")) + " litraa, kustannus " + (kustannus.ToString("N2")) + " euroa");
        }
    }
}
