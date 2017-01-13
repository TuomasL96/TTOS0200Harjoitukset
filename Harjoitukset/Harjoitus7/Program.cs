using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("Anna vuosiluku: ");
            vuosi = Int32.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(vuosi))
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            } 
        }
    }
}
