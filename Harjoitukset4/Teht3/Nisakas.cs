using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    public abstract class Nisakas
    {
        public int Ika { get; set; }
        public abstract string Liiku();
    }
    public class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set; }
        public Ihminen(string nimi, int paino, int pituus, int ika)
        {
            Ika = ika;
            Nimi = nimi;
            Paino = paino;
            Pituus = Pituus;
        }
        public override string Liiku()
        {
            return string.Format("Liikun");
        }
        public void Kasva()
        {
            Ika = Ika++;
        }

    }
}
