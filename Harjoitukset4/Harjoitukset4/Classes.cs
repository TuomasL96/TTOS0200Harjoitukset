using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Kulkuneuvo
    {
        public List<Rengas> lista = new List<Rengas>();
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int RengasMaara;

        public Kulkuneuvo(string nimi, string malli, int rengasmra)
        {
            Nimi = nimi;
            Malli = malli;
            RengasMaara = rengasmra;
        }

        public override string ToString()
        {
            return "\nVehicle Name:" + Nimi + " Model: " + Malli;
        }

        public void AddRengas(string merkki, string tyyppi, string koko)
        {
            lista.Add(new Rengas(merkki, tyyppi, koko));
            Console.WriteLine("Tyre {0} added to vehicle {1}.", merkki, Nimi);
        }

        public List<Rengas> Renkaat
        {
            get { return lista; }
        }
    }
    class Rengas
    {
        public string malli { get; set; }
        public string tyyppi { get; set; }
        public string koko { get; set; }

        public Rengas(string Malli, string Typpi, string Koko)
        {
            malli = Malli;
            tyyppi = tyyppi;
            koko = Koko;
        }
    }
}
