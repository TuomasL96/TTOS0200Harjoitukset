using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit;
            Console.Write("Anna sekunnit: ");
            sekunnit = Int32.Parse(Console.ReadLine());
            var timeSpan = TimeSpan.FromSeconds(sekunnit);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmasta muodossa: " + hh + " tunti(a) " + mm + " minuutti(a) " + ss +" sekunti(a) ");
        }
    }
}
