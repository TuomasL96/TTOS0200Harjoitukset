using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT1;

namespace KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }
        static void TestaaKiuas()
        {
            Kiuas munKiuas = new Kiuas();
            munKiuas.onOff = true;

            Console.WriteLine("Anna kiukaan lämpötila:");
            munKiuas.lämpötila = float.Parse(Console.ReadLine());

            Console.WriteLine("Anna ilmankosteus: ");
            munKiuas.Kosteus = float.Parse(Console.ReadLine());
            Console.WriteLine("kiuas on päällä:" + munKiuas.onOff);
            Console.WriteLine("Lämpötila: " + munKiuas.lämpötila);
            Console.WriteLine("ilmankosteus: " + munKiuas.Kosteus);
        }
    }
}
