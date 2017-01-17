using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpiskelijaTunnus { get; set; }
        public string LuokkaTunnus { get; set; }
        public int Ika { get; set; }

        public Opiskelija(string eNimi, string sNimi, string opiskelijaT, string luokkaT, int ika)
        {
            this.Etunimi = eNimi;
            this.Sukunimi = sNimi;
            this.OpiskelijaTunnus = opiskelijaT;
            this.LuokkaTunnus = luokkaT;
            this.Ika = ika;
        }

        public void PrintData()
        {
            Console.WriteLine("Etunimi: " + Etunimi);
            Console.WriteLine("Sukunimi: " + Sukunimi);
            Console.WriteLine("Opiskelijatunnus: " + OpiskelijaTunnus);
            Console.WriteLine("Luokkatunnus: " + LuokkaTunnus);
            Console.WriteLine("Ika: " + Ika);
            Console.WriteLine("*******************************");
        }
       
    }
}
