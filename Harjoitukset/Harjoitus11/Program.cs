using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit;
            Console.Write("Anna tahtirivien maara: ");
            rivit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < rivit; i++)
            {
                for (int a = 0; a <= i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }           
        }
    }
}
