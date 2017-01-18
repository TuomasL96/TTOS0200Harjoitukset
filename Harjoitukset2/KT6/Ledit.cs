using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KT6;

namespace KT6
{
    class Ledit
    {
        public bool OnOff { get; set; }
        public bool Strobe { get; set; }
        public string Väri { get; set; }
        int kirkkaus;

        public int Kirkkaus
        {
            get { return kirkkaus; }
            set
            {
                kirkkaus = value;

                if (kirkkaus < 0 || kirkkaus > 100)
                {
                   kirkkaus = 50;
                }
            }
        }

        public Ledit(bool onoff, bool strobe, string väri, int kirkkaus)
        {
            OnOff = onoff;
            if (OnOff == true)
            {
                this.Strobe = strobe;
                this.Väri = väri;
                this.Kirkkaus = kirkkaus;
            }
            else
            {
                this.Strobe = false;
                this.Väri = "Valot eivät ole päällä!";
                this.Kirkkaus = 0;
            }
        }
    }
}
