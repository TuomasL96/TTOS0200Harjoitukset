using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen miikka = new Ihminen("Miikka", 70, 175, 18);
            Vauva matti = new Vauva("Matti", 10, 50, 1, "Pampers");
            Aikuinen marja = new Aikuinen("Marja", 90, 160, 70, "Saab 900");

            Console.WriteLine("\n{0} Sanoo {1}, Hänen tietonsa: \n{2}", marja.Nimi, marja.Liiku(), marja.ToString());
            Console.WriteLine("\n{0} Sanoo {1}, Hänen tietonsa: \n{2}", miikka.Nimi, miikka.Liiku(), miikka.ToString());
            Console.WriteLine("\n{0} Yrittää Sanoa {1}, Hänen tietonsa: \n{2}", matti.Nimi, matti.Liiku(), matti.ToString());
        }
    }
}
