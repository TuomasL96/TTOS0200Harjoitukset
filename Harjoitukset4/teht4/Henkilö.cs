using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teht4;

namespace teht4
{
    public class Ihminen
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }
        public Ihminen(string nimi, int ikä)
        {
            Nimi = nimi;
            Ikä = ikä;
        }
    }
    class Työntekijä : Ihminen
    {   
        public string TyöID { get; set; }

        public Työntekijä(string nimi, int ikä, string työid)
            :base(nimi, ikä)
        {
            TyöID = työid;
        }
    }
    class Asiakas : Ihminen
    {
        public string AsiakasID { get; set; }

        public Asiakas(string nimi, int ikä, string asiakasid)
            :base(nimi, ikä)
        {
            AsiakasID = asiakasid;
        }
    }
}
