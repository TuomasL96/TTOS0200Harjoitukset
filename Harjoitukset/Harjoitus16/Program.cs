using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus16
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvausKerrat = 0;
            int arvaus = new Int32();
            Random rnd = new Random();
            int luku = rnd.Next(0, 100);
            do
            {
                Console.Write("Arvaa Luku: ");
                arvaus = Int32.Parse(Console.ReadLine());
                arvausKerrat++;
                if (arvaus < luku)
                {
                    Console.WriteLine("Luku on suurempi");
                }
                else if (arvaus > luku)
                {
                    Console.WriteLine("Luku on pienempi");
                }
            } while (arvaus != luku);
            Console.WriteLine("Hienoa, arvasit luvun " + arvausKerrat + " kerralla");
        }
    }
}
