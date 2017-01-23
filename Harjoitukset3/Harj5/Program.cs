using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T5;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaRadio();
        }
        static void TestaaRadio()
        {
            Radio radio = new Radio();
            while (true)
            {
                Console.WriteLine("\nRadion tiedot: \nPäällä: " + radio.Päällä + " Äänenvoimakkuus: " + radio.Ääni + " Taajuus: " + string.Format((radio.Taajuus).ToString("F1")));
                Console.WriteLine("1. Sammuta/laita radio päälle\n2. Vaihda taajuutta\n3. Vaihda Äänenvoimakkuutta");
                int valikko = int.Parse(Console.ReadLine());
                switch (valikko)
                {
                    case 1:
                        radio.Päällä = !radio.Päällä;
                        break;
                    case 2:
                        Console.Write("Uusi taajuus: ");
                        radio.Taajuus = Math.Round(double.Parse(Console.ReadLine()), 1, MidpointRounding.AwayFromZero);
                        Console.WriteLine(radio.Tulostus);
                        break;
                    case 3:
                        Console.Write("Uusi äänenvoimakkuus: ");
                        radio.Ääni = int.Parse(Console.ReadLine());
                        Console.WriteLine(radio.Tulostus);
                        break;
                    default:
                        Console.WriteLine("Virheellinen syöte");
                        break;
                }

            }
        }
    }
}
