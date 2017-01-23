using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Hissi
    {
        private const int max = 5;
        private const int min = 1;
        private int floor = 1;
        private string tila;

        public int Floor
        {
            get { return floor; }
            set
            {
                if (value < min)
                {
                    tila = "Floor is too small!";
                }
                else if (value > max)
                {
                    tila = "Floor is too big!";
                }
                else
                {
                    floor = value;
                    tila = "Elevator is now in floor: " + floor;
                }
            }
        }
        public string Tila
        {
            get { return tila; }
        }
    }
}
