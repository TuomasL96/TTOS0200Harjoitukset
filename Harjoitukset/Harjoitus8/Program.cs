using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            int lukuA, lukuB, lukuC;
            Console.WriteLine("Anna kolme lukua:");
            lukuA = Int32.Parse(Console.ReadLine());
            lukuB = Int32.Parse(Console.ReadLine());
            lukuC = Int32.Parse(Console.ReadLine());
            int[] luvut = { lukuA, lukuB, lukuC };
            Array.Sort(luvut);
            Console.WriteLine("Suurin luku on " + luvut[2]);
        }
    }
}
