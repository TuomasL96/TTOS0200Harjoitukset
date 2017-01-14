using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] taulu2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] taulu3 = new int[10];
            Array.Copy(taulu1, taulu3, 5);
            Array.Copy(taulu2, 0, taulu3, 5, 5);
            Array.Sort(taulu3);
            Console.Write("Luvut taulukossa 1 : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(taulu1[i] + ",");
            }
            Console.WriteLine();
            Console.Write("Luvut taulukossa 2 : ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(taulu2[j] + ",");
            }
            Console.WriteLine();
            Console.Write("Luvut yhdistetyssa taulukossa : ");
            for (int k = 0; k < 10; k++)
            {
                Console.Write(taulu3[k] + ",");
            }
            Console.WriteLine();
        }
    }
}
