using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet: ");
                pisteet[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(pisteet);
            int kokonais = pisteet.Sum() - pisteet[0] - pisteet[4];
            Console.WriteLine("Kokonaispisteet ovat " + kokonais);
        }
    }
}
