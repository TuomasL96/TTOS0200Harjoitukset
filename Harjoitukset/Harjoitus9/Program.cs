using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int kokonais = 0;
            do
            {
                Console.Write("Anna Luku: ");
                luku = Int32.Parse(Console.ReadLine());
                kokonais = kokonais + luku;

            } while (luku != 0);
            Console.WriteLine("Lukujen summa on " + kokonais);
        }
    }
}
