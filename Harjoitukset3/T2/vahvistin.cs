using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Vahvistin
    {
        private const int max = 100;
        private const int min = 0;
        private int voimakkuus;
        private string tulostus;

        public int Voimakkuus
        {
            get { return voimakkuus; }
            set
            {
                if (value > max)
                {
                    voimakkuus = max;
                    tulostus = "Too much volume -  Amplifier volume is set to maximum : 100";
                }
                if (value < min)
                {
                    voimakkuus = min;
                    tulostus = "Too low volume -  Amplifier volume is set to minimum : 0";
                }
                if (value < max && value > min)
                {
                    voimakkuus = value;
                    tulostus = "Amplifier volume is set to : " + value;
                }
            }
        }
        public string Tulostus
        {
            get { return tulostus; }
        }
    }
}
