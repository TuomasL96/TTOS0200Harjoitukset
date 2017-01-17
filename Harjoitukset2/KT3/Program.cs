using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT3;

namespace KT3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaTelevisio();
        }
        static void TestaaTelevisio()
        {
            Televisio telkkari = new Televisio(true, 1, 30);
            Console.WriteLine("TV on paalla: " + telkkari.OnOff);
            Console.WriteLine("Kanava on: " + telkkari.Kanava + ", Äänenvoimakkuus: " + telkkari.ÄänenVoimakkuus);
        }
    }
}
