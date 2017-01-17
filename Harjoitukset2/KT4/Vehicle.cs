using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT4;

namespace KT4
{
    class Vehicle
    {
        //prop
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        //methods
        public void PrintData()
        {
            Console.WriteLine("Auton nimi: " + Name);
            Console.WriteLine("Auton nopeus : " + Speed);
            Console.WriteLine("Auton renkaat : " + Tyres);
        }
        public override string ToString()
        {
            string kaikkiTiedot = "Nimi: " + Name + "," + "Nopeus: " + Speed + "," + "Renkaat: " + Tyres;
            return kaikkiTiedot;
        }
    }
}
