using System;

namespace Harj3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRegister();
        }
        static void TestRegister()
        {
            FisherRegister register = new FisherRegister();
            Fisher kirsi = new Fisher("Kirsi Kernel", "020-12345678");
            Fisher tuomas = new Fisher("Tuomas Luukinen", "012-3456789");
            Location teno = new Location("River Teno", "The Northern edge of Finland");
            Location jyvaskyla = new Location("The lake of jyväskylä", "Jyväskylä");

            register.AddFisher(kirsi);
            register.AddFisher(tuomas);
            tuomas.AddFish(new Fish("trout", 150, 20.5, teno));
            tuomas.AddFish(new Fish("bass", 120, 10.2, teno));
            kirsi.AddFish(new Fish("pike", 120, 4.5, jyvaskyla));
            kirsi.AddFish(new Fish("salmon", 190, 13.2, teno));
            Console.WriteLine(register.PrintRegister());
        }
    }
}
