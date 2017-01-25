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
            string päiväys;
            List<string> tuotteet = new List<string>();
            Jääkaappi jääkaappi = new Jääkaappi("Electrolux");

            jääkaappi.LisääTuote(new Tuote("Makkara", "13.2.2017"));
            jääkaappi.LisääTuote(new Tuote("Juusto", "02.2.2017"));
            jääkaappi.LisääTuote(new Tuote("Maitotölkki", "13.1.2017"));

            Console.WriteLine(jääkaappi.ToString());
            for (int i = 0; i < jääkaappi.tuotteet.Count; i++)
            {
                Console.WriteLine("Tuote " + i +".- {0}, vanhenee: {1}",jääkaappi.tuotteet[i].Nimi,jääkaappi.tuotteet[i].Päiväys);
            }
            // jääkaapin testailua
            while (toisto == true)
            {
                Console.WriteLine("\n0. lopeta, 1. Lisää tuote, 2. Poista tuote, 3. Tarkista tuotteet kaapissa"); // tuotteen poisto ei toimi
                int valinta = int.Parse(Console.ReadLine());
                switch (valinta)
                {
                    case 0:
                        toisto = false;
                        break;
                    case 1:
                        Console.Write("Anna tuotteen nimi: ");
                        nimi = Console.ReadLine();
                        Console.Write("Päiväys: ");
                        päiväys = Console.ReadLine();
                        jääkaappi.LisääTuote(new Tuote(nimi,päiväys));
                        break;
                    case 2:
                        Console.Write("Anna tuotteen nimi: ");
                        nimi = Console.ReadLine();
                        Console.Write("Päiväys: ");
                        päiväys = Console.ReadLine();
                        jääkaappi.PoistaTuote(new Tuote(nimi,päiväys));
                        break;
                    case 3:
                        Console.WriteLine(jääkaappi.ToString());
                        for (int i = 0; i < jääkaappi.tuotteet.Count; i++)
                        {
                            Console.WriteLine("Tuote " + i + ".- {0}, vanhenee: {1}", jääkaappi.tuotteet[i].Nimi, jääkaappi.tuotteet[i].Päiväys);
                        }
                        break;
                }
            }
        }
    }
}
