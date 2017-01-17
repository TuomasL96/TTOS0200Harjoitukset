using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1
{
    class Kiuas
    {
        public bool onOff { get; set; }
        public float lämpötila { get; set; }
        float kosteus;

        public float Kosteus
        {
            get { return kosteus; }
            set
            {
                kosteus = value;

                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }
        }
    }
}
