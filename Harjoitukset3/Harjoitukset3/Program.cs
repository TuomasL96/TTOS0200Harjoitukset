using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitukset3;

namespace Harjoitukset3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHissi();
        }
        static void TestaaHissi()
        {
            Hissi hissi = new Hissi();
            Console.WriteLine("Elevator is now in floor: " + hissi.Floor);
            while (true)
            {
                Console.Write("Give a new floor number (1-5): ");
                hissi.Floor = int.Parse(Console.ReadLine());
                Console.WriteLine(hissi.Tila);
            }
        }
    }
}
