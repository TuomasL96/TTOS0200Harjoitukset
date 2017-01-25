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
            tuotteet.Add(tuote);
        }
        public void PoistaTuote(Tuote tuote)
        {
            tuotteet.Remove(tuote);
        }
        public override string ToString()
        {
            return "Jääkaappi mallia " + Nimi + " sisältää:";
        }
    }
    class Tuote
    {
        public string Nimi { get; set; }
        public string Päiväys { get; set; }
        public Tuote(string nimi, string päiväys)
        {
            Nimi = nimi;
            Päiväys = päiväys;
        }
    }
}
