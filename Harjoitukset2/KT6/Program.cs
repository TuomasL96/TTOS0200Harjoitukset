using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT6;

namespace KT6
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaLedit();
        }
        static void TestaaLedit()
        {
            bool paalla;
            bool strobaa = new bool();
            string vari;
            int valo;
            Console.WriteLine("Onko ledit päällä(true/false): ");
            paalla = bool.Parse(Console.ReadLine());
            Console.WriteLine("välkkyykö ne(true/false): ");
            strobaa = bool.Parse(Console.ReadLine());
            Console.WriteLine("Niiden väri: ");
            vari = Console.ReadLine();
            Console.WriteLine("Niiden kirkkaus 0-100(%): ");
            valo = int.Parse(Console.ReadLine());

            Ledit valot = new Ledit(paalla,strobaa,vari,valo);
            Console.WriteLine("Ledit päällä: " + valot.OnOff + ", Ne välkkyy: " + valot.Strobe + ", Niiden väri on: " + valot.Väri + ", Niiden kirkkaus: " + valot.Kirkkaus + "%");
        }
    }
}
