using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvot = { 1, 22, 23, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i <= 8; i++)
            {
                if (arvot[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
        }
    }
}
