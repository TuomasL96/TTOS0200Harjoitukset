using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            float lukuA, lukuB, lukuC;
            Console.WriteLine("Anna kolme lukua: ");
            lukuA = float.Parse(Console.ReadLine());
            lukuB = float.Parse(Console.ReadLine());
            lukuC = float.Parse(Console.ReadLine());
            float summa = lukuA + lukuB + lukuC;
            float keskiarvo = (lukuA + lukuB + lukuC) / 3;
            Console.WriteLine("Summa: " + summa + ", Keskiarvo: " + keskiarvo);
        }
    }
}
