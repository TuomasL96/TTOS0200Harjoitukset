using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tulostus = new string[6];
            bool toisto = true;
            int arvosanat;
            Console.WriteLine("Anna opiskelijoiden arvosanat(0-5)");
            Console.WriteLine("Arvosanojen antamisen voit lopettaa antamalla numeron 10");
            do
            {
                Console.Write("Anna arvosana: ");
                arvosanat = int.Parse(Console.ReadLine());
                switch (arvosanat)
                {
                    case 0:
                        tulostus[0] += "*";
                        break;
                    case 1:
                        tulostus[1] += "*";
                        break;
                    case 2:
                        tulostus[2] += "*";
                        break;
                    case 3:
                        tulostus[3] += "*";
                        break;
                    case 4:
                        tulostus[4] += "*";
                        break;
                    case 5:
                        tulostus[5] += "*";
                        break;
                    case 10:
                        toisto = false;
                        break;
                    default:
                        Console.WriteLine("VIRHE!! Anna arvosana numerona 0-5, tai anna numero 10 lopettaaksesi!");
                        break;
                }
            } while (toisto == true);
            Console.WriteLine("Arvosanat:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i + ":" + tulostus[i]);
            }
        }
    }
}
