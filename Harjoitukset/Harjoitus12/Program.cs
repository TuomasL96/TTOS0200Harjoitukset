using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna Luku: ");
                taulu[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(taulu);
            Console.Write("Luvut ovat: ");
            for (int a = 0; a < 4; a++)
            {
                Console.Write(taulu[a] + ",");
            }
            Console.WriteLine(taulu[4]);
        }
    }
}
