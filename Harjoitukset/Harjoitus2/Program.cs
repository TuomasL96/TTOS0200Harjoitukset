using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna pistemaara: ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                case 1:
                    Console.WriteLine("Numero: 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Numero: 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Numero: 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Numero: 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Numero: 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Numero: 5");
                    break;
                default:
                    Console.WriteLine("Virhe: Anna pistemaara valilta 0-12");
                    break;
            }
        }
    }
}
