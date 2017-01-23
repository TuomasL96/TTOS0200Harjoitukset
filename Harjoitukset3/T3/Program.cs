using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaTiedot();
        }
        static void TestaaTiedot()
        {
            Employee henkilo = new Employee("Pekka", "Rekkakuski", 2500);
            Boss ihminen = new Boss("Tuomas", "Rekkafirman johtaja", 5000, "Saab", 3500);
            Console.WriteLine("Employee:");
            Console.WriteLine(henkilo.ToString());
            Console.WriteLine("Boss:");
            Console.WriteLine(ihminen.ToString());
        }
    }
}
