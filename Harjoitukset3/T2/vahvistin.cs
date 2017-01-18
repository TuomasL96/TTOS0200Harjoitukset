using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class vahvistin
    {
        private int maxVoimakkuus = 100;
        private int minVoimakkuus = 0;
        private int voimakkuus;
        public string Tulostus;

        public int Voimakkuus
        {
            get { return voimakkuus; }
            set
            {
                voimakkuus = value;
                if (voimakkuus > maxVoimakkuus)
                {
                    voimakkuus = 100;
                    Tulostus = "Too much volume -  Amplifier volume is set to maximum : 100";
                }
            }
        }  


        
    }
}
