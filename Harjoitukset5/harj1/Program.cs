using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T1
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }
        static void TestaaHenkiloRekisteri()
        {
            string id;
            //luodaan henkilöt
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "abc" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "123" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "456" };
            //lisätään ne poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            id = Console.ReadLine();
            Console.WriteLine(poppoo.HaeHenkiloHetulla(id));
            //Hae hetu ja etsi sitä vastaava henkilö
        }
    }
}
