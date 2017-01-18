using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT4;

namespace KT4
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleTesti();
        }
        static void VehicleTesti()
        {
            while (true)
                Vehicle munAuto = new Vehicle();

                Console.WriteLine("Anna auton nimi");
                munAuto.Name = Console.ReadLine();

                Console.WriteLine("Anna auton nopeus");
                munAuto.Speed = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna auton renkaiden koko");
                munAuto.Tyres = int.Parse(Console.ReadLine());
                   
                munAuto.PrintData();
                string yhdesPutkes = munAuto.ToString();
                Console.WriteLine(yhdesPutkes);
            }
        }
    }
}
