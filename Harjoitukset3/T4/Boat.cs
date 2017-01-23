using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4;

namespace T4
{
    class Boat : Kulkuneuvo
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat(string nimi, string model, int year, string color, int seatcount, string boattype)
            : base(nimi, model, year, color)
        {
            SeatCount = seatcount;
            BoatType = boattype;
        }    

        public override string ToString()
        {
            return base.ToString() + " SeatCount:" + SeatCount + " BoatType:" + BoatType;
        }
    }
}
