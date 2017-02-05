using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj3
{
    class Program
    {
        static void Main(string[] args)
        {
            FisherRegister register = new FisherRegister();
            Fisher kirsi = new Fisher ("Kirsi Kernel", "020-12345678");
            Location teno = new Location("River Teno", "The Northern edge of Finland");
            Location jyvaskyla = new Location("The lake of jyväskylä", "Jyväskylä");
            register.AddFisher(kirsi);
            kirsi.AddFish(new Fish("pike", 120, 4.5, jyvaskyla));
            kirsi.AddFish(new Fish("salmon", 190, 13.2, teno));
            Console.WriteLine(register.PrintRegister());
        }
    }
}
