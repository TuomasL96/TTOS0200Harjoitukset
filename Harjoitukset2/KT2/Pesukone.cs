using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Pesukone
    {
        public string PesuTyyli { get; set; }
        public int Pesuaika { get; set; }
        public bool OnOff { get; set; }

        public Pesukone(bool paalla, int aika, string tyyli)
        {
            OnOff = paalla;
            if (OnOff == true)
            {
                Pesuaika = aika;
                PesuTyyli = tyyli;
            }
        }
    }
}
