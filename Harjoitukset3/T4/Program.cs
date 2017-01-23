using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKulkuneuvot();
        }
        static void TestaaKulkuneuvot()
        {
            Bike bike = new Bike("Jopo", "Street", 2016, "Blue", false);
            Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Boat boat = new Boat("Suvi", "S900", 1990, "White", 3, "Row Boat");
            Boat boat2 = new Boat("Yamaha", "1000", 2010, "Yellow", 5, "Motorboat");
            Console.WriteLine("Bike info \n" + bike.ToString() + "\n");
            Console.WriteLine("Bike2 info \n" + bike2.ToString() + "\n");
            Console.WriteLine("Boat info \n" + boat.ToString() + "\n");
            Console.WriteLine("Boa2t info \n" + boat2.ToString() + "\n");
        }
    }
}
