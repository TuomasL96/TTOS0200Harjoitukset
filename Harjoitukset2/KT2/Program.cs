using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT2;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaPesukone();
        }
        static void TestaaPesukone()
        {
            Pesukone munKone = new Pesukone(true, 60, "Hienopesu");
            if (munKone.OnOff == true)
            {
                Console.WriteLine("Pesukone pyörii seuraavat " + munKone.Pesuaika + " minuuttia, pesutyyli on: " + munKone.PesuTyyli);
            }
            else
            {
                Console.WriteLine("Pesukone ei ole päällä!");
            }
        }
    }
}
