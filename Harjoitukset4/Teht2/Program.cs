using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toisto = true;
            string nimi;
            int maara;
            List<string> tuotteet = new List<string>();
            Jääkaappi jääkaappi = new Jääkaappi("Electrolux");

            Console.WriteLine(jääkaappi.ToString());
            for (int i = 0; i < jääkaappi.tuotteet.Count; i++)
            {
                Console.WriteLine("Tuotetta {0} on {1} kpl", jääkaappi.tuotteet[i].Nimi,jääkaappi.tuotteet[i].Määrä);
            }
            // jääkaapin testailua
            while (toisto == true)
            {
                Console.WriteLine("\n0. lopeta, 1. Lisää tuote, 2. Poista tuote, 3. Tarkista tuotteet kaapissa");
                int valinta = int.Parse(Console.ReadLine());
                switch (valinta)
                {
                    case 0:
                        toisto = false;
                        break;
                    case 1:
                        Console.Write("Anna tuotteen nimi: ");
                        nimi = Console.ReadLine();
                        Console.Write("Määrä: ");
                        maara = int.Parse(Console.ReadLine());
                        jääkaappi.LisääTuote(new Tuote(nimi,maara));
                        break;
                    case 2:
                        Console.Write("Anna tuotteen nimi: ");
                        string pnimi = Console.ReadLine();
                        Console.Write("Määrä: ");
                        maara = int.Parse(Console.ReadLine());
                        jääkaappi.PoistaTuote(maara);
                        break;
                    case 3:
                        Console.WriteLine(jääkaappi.ToString());
                        for (int i = 0; i < jääkaappi.tuotteet.Count; i++)
                        {
                            Console.WriteLine("Tuotetta {0} on {1} kpl", jääkaappi.tuotteet[i].Nimi, jääkaappi.tuotteet[i].Määrä);
                        }
                        break;
                }
            }
        }
    }
}
