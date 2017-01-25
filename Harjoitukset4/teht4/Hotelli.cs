using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teht4;

namespace teht4
{
        class Hotelli
        {
            public List<Huone> Huoneet { get; set; }
            public List<Työntekijä> työntekijät = new List<Työntekijä>();
            public List<Asiakas> Asiakkaat { get; set; }
            public string Osoite { get; set; }
            public string Nimi { get; set; }
            public Hotelli(string nimi, string osoite)
            {
                Nimi = nimi;
                Osoite = osoite;
            }
            public void LisääTyöntekijä(Työntekijä Työntekijä)
            {
                työntekijät.Add(Työntekijä);
            }
    }
        class Huone
        {
            public bool Varattu { get; set; }
            public Asiakas HuoneenAsiakas { get; set; }
            public int RoomNumber { get; set; }
            public Huone(int rmnumber)
            {
                Varattu = false;
                RoomNumber = rmnumber;
            }
            public Huone(Asiakas asiakas, int rmnumber)
            {
            Varattu = true;
            RoomNumber = rmnumber;
            HuoneenAsiakas = asiakas;
            }
    }
}

