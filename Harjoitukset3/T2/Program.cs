using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            ÄänenVoima();
        }
        static void ÄänenVoima()
        {
            Vahvistin vahv = new Vahvistin();
            while (true)
            {
                Console.Write("Give a new volume value (0-100) > ");
                vahv.Voimakkuus = int.Parse(Console.ReadLine());
                Console.WriteLine(vahv.Tulostus);
            }
        }
    }
}
