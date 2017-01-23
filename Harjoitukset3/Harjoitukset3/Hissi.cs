using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset3
{
    class Hissi
    {
        public int CurrentFloor { get; set; }
        private int wantedFloor { get; set; }
        public string Tila { get; set; }
        public int WantedFloor
        {
            get
            {
                return wantedFloor;
            }
            set
            {
                if (value >= 1 || value <= 5 )
                {
                    this.WurrentFloor = value;
                    Tila = "Elevator is now in floor: " + CurrentFloor;
                }
                else
                {
                    Tila = "Floor number must be a value 1-5";
                }
            }
        }
    }
}
