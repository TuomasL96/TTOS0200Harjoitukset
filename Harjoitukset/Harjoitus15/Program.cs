using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus15
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit;
            Console.WriteLine("Anna luku");
            rivit = Int32.Parse(Console.ReadLine());
            rivit = rivit - 2;
            for (int i = 0; i < rivit; i++)
            {
                for (int x = 0; x < rivit - i - 1; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < rivit - 1; x++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
