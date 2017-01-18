using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Opiskelija
    {
        private string etunimi { get; set; }
        private string sukunimi { get; set; }
        private string opiskelijaTunnus { get; set; }
        private string luokkaTunnus { get; set; }
        private int ika { get; set; }

        public Opiskelija(string eNimi, string sNimi, string opiskelijaT, string luokkaT, int ikaA)
        {
            this.etunimi = eNimi;
            this.sukunimi = sNimi;
            this.opiskelijaTunnus = opiskelijaT;
            this.luokkaTunnus = luokkaT;
            this.ika = ikaA;
        }

        public void PrintData()
        {
            Console.WriteLine("Etunimi: " + etunimi);
            Console.WriteLine("Sukunimi: " + sukunimi);
            Console.WriteLine("Opiskelijatunnus: " + opiskelijaTunnus);
            Console.WriteLine("Luokkatunnus: " + luokkaTunnus);
            Console.WriteLine("Ika: " + ika);
            Console.WriteLine("*******************************");
        }
       
    }
}
