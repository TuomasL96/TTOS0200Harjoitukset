using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4;

namespace T4
{
    class Bike : Kulkuneuvo
    {
        public bool GearWheels { get; set; }
        private string gearmodel { get; set; }

        public Bike(string nimi, string model, int year, string color, bool gearwheels, string gearmodel)
            : base(nimi, model, year, color)
        {
            GearWheels = gearwheels;
            GearModel = gearmodel;
        }

        public Bike(string nimi, string model, int year, string color, bool gearwheels)
            : base(nimi, model, year, color)
        {
            GearWheels = gearwheels;
            GearModel = "";
        }

        public string GearModel
        {
            get { return gearmodel; }
            set
            {
                if (GearWheels == true)
                {
                    gearmodel = value;
                }
                else
                {
                    gearmodel = "";
                }
            }
        }
    
        public override string ToString()
        {
            return base.ToString() + " GearWheels:" + GearWheels + " GearName:" + GearModel;
        }
    }
}
