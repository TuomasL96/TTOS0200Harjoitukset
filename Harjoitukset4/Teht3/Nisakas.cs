using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    public abstract class Nisakas
    {
        public int Ikä { get; set; }
        public abstract string Liiku();
        public Nisakas(int ikä)
        {
            Ikä = ikä;
        }
    }

    public class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public float Paino { get; set; }
        public float Pituus { get; set; }

        public Ihminen(string nimi, float paino, float pituus, int ikä)
            : base (ikä)
        {
            Nimi = nimi;
            Paino = paino;
            Pituus = pituus;
        }
        public override string Liiku()
        {
            return "'liikun'";
        }
        public void Kasva()
        {
            Ikä++;
        }
        public override string ToString()
        {
            return "Paino: " + Paino + ", Pituus: " + Pituus + ", Ikä: " + Ikä; 
        }
    }

    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string nimi, float paino, float pituus, int ikä, string auto)
            : base(nimi, paino, pituus, ikä)
        {
            Auto = auto;
        }

        public override string Liiku()
        {
            return "'kävelen'";
        }
        public override string ToString()
        {
            return base.ToString() + ", Auto: " + Auto;
        }
    }

    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string nimi, float paino, float pituus, int ikä, string vaippa)
            : base(nimi, paino, pituus, ikä)
        {
            Vaippa = vaippa;
        }

        public override string Liiku()
        {
            return "'konttaan!'";
        }
        public override string ToString()
        {
            return base.ToString() + ", Vaipan merkki: " + Vaippa;
        }
    }
}
