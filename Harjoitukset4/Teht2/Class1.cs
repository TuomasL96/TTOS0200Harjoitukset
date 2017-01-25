using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Jääkaappi
    {
        public List<Tuote> tuotteet = new List<Tuote>();
        public string Nimi { get; set; }
        public Jääkaappi(string nimi)
        {
            Nimi = nimi;
        }
        public void LisääTuote(Tuote tuote)
        {
            if (!(tuotteet.Contains(new Tuote(tuote.Nimi, tuote.Määrä)) && tuote.Määrä > 0));
            {
                tuotteet.Add(tuote);
            }
        }
        public void PoistaTuote(Tuote tuote)
        {
            if (tuotteet.Contains(tuote) && tuote.Määrä > 0)
            {
                tuotteet.Remove(tuote);
            }
        }
        public override string ToString()
        {
            return "Jääkaappi mallia " + Nimi + " sisältää:";
        }
    }
    class Tuote
    {
        public string Nimi { get; set; }
        public int Määrä { get; set; }
        public Tuote(string nimi, int määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
        }
        public override bool Equals(Tuote tuot)
        {
            if this.Nimi == other.nimi
        }
    }
}
