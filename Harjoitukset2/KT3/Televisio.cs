using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class Televisio
    {
        int äänenVoimakkuus;
        public int Kanava { get; set; }
        public bool OnOff { get; set; }

        public int ÄänenVoimakkuus
        {
            get { return äänenVoimakkuus; }
            set
            {
                äänenVoimakkuus = value;

                if (äänenVoimakkuus < 0 || äänenVoimakkuus > 100)
                {
                    äänenVoimakkuus = 50;
                }
            }
        }
        public Televisio(bool paalla, int kanava, int ääni)
        {
            OnOff = paalla;
            if (OnOff == true)
            {
                this.Kanava = kanava;
                this.ÄänenVoimakkuus = ääni;
            }
            else
            {
                this.Kanava = 0;
                this.ÄänenVoimakkuus = 0;
            }
        }

    }
}
