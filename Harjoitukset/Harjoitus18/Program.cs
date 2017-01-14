using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus18
{
    class Program
    {
        static void Main(string[] args)
        {
            string lause;
            char[] juttuA;
            Console.WriteLine("Anna lause");
            lause = Console.ReadLine();
            // poistetaan välit ja merkit että tämä toimii
            lause = lause.Replace(" ", "");
            lause = lause.Replace(",", "");
            juttuA = lause.ToCharArray();
            Array.Reverse(juttuA);
            string lauseB = new string(juttuA);
            if (lause == lauseB)
            {
                Console.WriteLine("Lause on palidromi");
            }
            else
            {
                Console.WriteLine("Lause ei ole palidromi");
            }
        }
    }
}
