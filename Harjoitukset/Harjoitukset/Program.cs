using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna luku 1, 2 tai 3: ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Annoit luvun yksi");
                    break;
                case 2:
                    Console.WriteLine("Annoit luvun kaksi");
                    break;
                case 3:
                    Console.WriteLine("Annoit luvun kolme");
                    break;
                default:
                    Console.WriteLine("joku muu luku");
                    break;
            }
        }
    }
}
