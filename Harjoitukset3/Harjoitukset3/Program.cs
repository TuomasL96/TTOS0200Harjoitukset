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
            Hissi hissiA = new Hissi();
            while (true)
            {
                Console.WriteLine("Elevator is now in floor: " + hissiA.CurrentFloor);
                Console.Write("Give a new floor number (1-5): ");
                hissiA.WantedFloor = int.Parse(Console.ReadLine());
            }
        }
    }
}
