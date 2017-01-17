using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus19
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvaus = 0;
            const int max = 9;
            char kirjain;
            bool toisto = true;
            string sana = "tietotekniikka";
            char[] piilo = new char[sana.Length];
            string kopio;
            for (int i = 0; i < sana.Length; i++)
            {
                piilo[i] = '_';
            }
            do
            {
                kopio = new string(piilo);
                if (arvaus == max)
                {
                    Console.WriteLine("JOUDUIT HIRTEEN!!");
                    toisto = false;
                    break;
                }
                if (sana == kopio)
                {
                    Console.WriteLine("Sana: " + kopio);
                    Console.WriteLine("Arvaukset: " + arvaus + "/" + max);
                    Console.WriteLine("Onneksi olkoon, arvasit oikein!");
                    toisto = false;
                    break;
                }
                Console.WriteLine("Sana: " + kopio);
                Console.WriteLine("Kaytetyt Arvaukset: " + arvaus + "/" + max);
                kirjain = char.Parse(Console.ReadLine());
                if (sana.Contains(kirjain) && !(piilo.Contains(kirjain)))
                {
                    for (int i = 0; i < sana.Length; i++)
                    {
                        if (sana[i] == kirjain)
                        {
                            piilo[i] = kirjain;
                        }
                    }
                }
                else
                {
                    arvaus++;
                }

            } while (toisto == true);
        }
    }
}
